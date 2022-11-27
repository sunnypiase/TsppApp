using System.Data;
using TsppAPI.Models;
using TsppApp.Services.Abstract;

namespace TsppApp
{
    internal partial class ProductActionForm : Form
    {
        private readonly IHttpClientService _httpClientService;
        private ICollection<ProductType>? _allTypes;
        private Product _inputProduct;
        public ProductDto Result { get; set; }

        public ProductActionForm(in IHttpClientService httpClientService)
        {
            InitializeComponent();
            _httpClientService = httpClientService;
            Result = new();
        }
        private async Task SetTypes() => _allTypes = await _httpClientService.GetAsync<ProductType>() ?? new List<ProductType>();
        public async void UpdateProduct(Product productToUpdate)
        {
            await SetTypes();
            _inputProduct = productToUpdate;
            SetBox(productToUpdate);
            Show();
        }
        public async void AddProduct()
        {
            await SetTypes();

            SetBox();
            Show();
        }
        private void SetBox(Product product)
        {
            NameTextBox.Text = product.Name;
            PriceTextBox.Text = product.Price.ToString();
            AmountTextBox.Text = product.Amount.ToString();
            WeightTextBox.Text = product.Weight.ToString();
            TypeListBox.Items.Clear();
            foreach (var type in _allTypes)
            {
                bool isChecked = product.Types.Contains(type);
                TypeListBox.Items.Add(type.TypeName, isChecked);

            }
        }
        private void SetBox()
        {
            TypeListBox.Items.Clear();
            foreach (var type in _allTypes)
            {
                TypeListBox.Items.Add(type.TypeName);
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            Result.Id = _inputProduct?.Id ?? 0;
            Result.Name = NameTextBox.Text;
            Result.Price = double.Parse(PriceTextBox.Text);
            Result.Weight = double.Parse(WeightTextBox.Text);
            Result.Amount = int.Parse(AmountTextBox.Text);
            Result.TypeIds = _allTypes.Where(type => TypeListBox.CheckedItems.Contains(type.TypeName)).Select(type => type.Id).ToList();
            Close();
        }
    }
}
