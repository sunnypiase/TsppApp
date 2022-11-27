using TsppAPI.Models;
using TsppApp.Services;
using TsppApp.ViewModel;

namespace TsppApp
{
    public partial class MainForm : Form
    {
        private readonly HttpClientService _httpClient = new();

        public MainForm()
        {
            InitializeComponent();
            poductDataGrid.AutoGenerateColumns = true;
            poductDataGrid.SelectionChanged += (sender, args) => OnSelectedChangedAction(sender, args);
            UpdateTable();
        }

        private void OnSelectedChangedAction(object sender, EventArgs e)
        {
            bool isEnabled = (sender as DataGridView)?.SelectedRows.Count == 1;
            DeleteProductBtn.Enabled = isEnabled;
            UpdateProductBtn.Enabled = isEnabled;
        }
        private async Task UpdateTable()
        {
            var getProductResponse = await _httpClient.GetAsync<Product>();
            poductDataGrid.DataSource = new ProductViewModelConverter().Convert(getProductResponse);
            poductDataGrid.Update();
        }
        private async void UpdateProductAction()
        {
            var productViewModel = poductDataGrid.CurrentRow.DataBoundItem as ProductViewModel;
            var actWind = new ProductActionForm(_httpClient);
            actWind.UpdateProduct(productViewModel.GetBaseModel());
            actWind.ShowDialog();
            var result = await _httpClient.PutAsync<Product, ProductDto>(actWind.Result);
            await UpdateTable();
        }
        private async void AddProductAction()
        {
            var actWind = new ProductActionForm(_httpClient);
            actWind.AddProduct();
            actWind.ShowDialog();
            var result = await _httpClient.PostAsync<Product, ProductDto>(actWind.Result);
            await UpdateTable();
        }
        private async void DeleteProductAction()
        {
            var productViewModel = poductDataGrid.CurrentRow.DataBoundItem as ProductViewModel;
            await _httpClient.DeleteAsync<Product>(productViewModel.GetBaseModel().Id);
            await UpdateTable();
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e) => DeleteProductAction();

        private void UpdateProductBtn_Click(object sender, EventArgs e) => UpdateProductAction();

        private void AddProductBtn_Click(object sender, EventArgs e) => AddProductAction();
        private void getProductsBtn_Click(object sender, EventArgs e) => UpdateTable();

    }
}