using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TsppAPI.Models;
using TsppApp.Services;
using TsppApp.Services.Abstract;

namespace TsppApp
{
    internal partial class ProductActionForm : Form
    {
        private readonly IHttpClientService _httpClientService;
        private Product _inputProduct;
        public ProductDto Result { get; set; }
        ICollection<ProductType>? allTypes;

        public ProductActionForm(in IHttpClientService httpClientService)
        {
            InitializeComponent();
            _httpClientService = httpClientService;
            Result = new();
        }
        private async Task SetTypes() => allTypes = await _httpClientService.GetAsync<ProductType>();
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
            foreach (var type in allTypes)
            {
                bool isChecked = product.Types.Contains(type);
                TypeListBox.Items.Add(type.TypeName, isChecked);

            }
        }
        private void SetBox()
        {
            TypeListBox.Items.Clear();
            foreach (var type in allTypes)
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
            Result.TypeIds = allTypes.Where(type => TypeListBox.CheckedItems.Contains(type.TypeName)).Select(type => type.Id).ToList();
            Close();
        }
    }
}
