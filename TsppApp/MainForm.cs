using TsppAPI.Models;
using TsppApp.Services;
using TsppApp.Services.Abstract;
using TsppApp.ViewModel;
using TsppApp.ViewModel.Abstract;

namespace TsppApp
{
    public partial class MainForm : Form
    {
        private readonly IHttpClientService _httpClient = new HttpClientService();
        private readonly ITableViewConverter<Product, ProductViewModel> _tableViewConverter = new ProductViewModelConverter();
        private readonly ProductActionForm _actionForm;
        public MainForm()
        {
            InitializeComponent();
            _actionForm = new(_httpClient);
            poductDataGrid.AutoGenerateColumns = true;
            poductDataGrid.SelectionChanged += (sender, args) => OnSelectedChangedAction(sender, args);
            try
            {
                UpdateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnSelectedChangedAction(object sender, EventArgs e)
        {
            try
            {
                bool isEnabled = (sender as DataGridView)?.SelectedRows.Count == 1;

                DeleteProductBtn.Enabled = isEnabled;
                UpdateProductBtn.Enabled = isEnabled;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task UpdateTable()
        {
            try
            {
                var getProductResponse = await _httpClient.GetAsync<Product>();

                poductDataGrid.DataSource = _tableViewConverter.Convert(getProductResponse);

                poductDataGrid.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void UpdateProductAction()
        {
            try
            {
                var product = (poductDataGrid.CurrentRow.DataBoundItem as ProductViewModel)?.GetBaseModel();

                _actionForm.UpdateProduct(product);
                _actionForm.ShowDialog();

                await _httpClient.PutAsync<Product, ProductDto>(_actionForm.Result);

                await UpdateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void AddProductAction()
        {
            try
            {
                _actionForm.AddProduct();
                _actionForm.ShowDialog();

                await _httpClient.PostAsync<Product, ProductDto>(_actionForm.Result);

                await UpdateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void DeleteProductAction()
        {
            try
            {
                var product = (poductDataGrid.CurrentRow.DataBoundItem as IViewModel<Product>)?.GetBaseModel();

                await _httpClient.DeleteAsync<Product>(product.Id);

                await UpdateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e) => DeleteProductAction();
        private void UpdateProductBtn_Click(object sender, EventArgs e) => UpdateProductAction();
        private void AddProductBtn_Click(object sender, EventArgs e) => AddProductAction();
        private void getProductsBtn_Click(object sender, EventArgs e) => UpdateTable();

    }
}