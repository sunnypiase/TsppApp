using TsppAPI.Models;
using TsppApp.Models.Filters;
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
                GetProductDtermBtn.Enabled = isEnabled;
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
                var getProductResponse = new List<Product>();


                if (!string.IsNullOrEmpty(priceFilterTextBox.Text) && double.TryParse(priceFilterTextBox.Text, out double filterPrice))
                {
                    getProductResponse = (await _httpClient.GetFilteredAsync<Product, ProductFilter>(new ProductFilter() { price = filterPrice })).ToList();
                }
                else
                {
                    getProductResponse = (await _httpClient.GetAsync<Product>()).ToList();
                }

                this.productPrecentageTextBox.Text = (getProductResponse.Count() / (double)(await _httpClient.GetAmountAsync<Product>()) * 100).ToString();

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
        private async void GetProductDeterm()
        {
            try
            {
                var product = (poductDataGrid.CurrentRow.DataBoundItem as ProductViewModel)?.GetBaseModel();

                List<List<double>> matrix = new()
                {
                    new() { product.Price, product.Amount },
                    new() { product.Weight, product.Types.Select(x=>x.Id).Sum() }
                };
                var res = await _httpClient.GetMatrixDetermenantAsync<Product>(new Models.MatrixDto() { Matrix = matrix });
                MessageBox.Show($"determ: {res}");
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

        private void button1_Click(object sender, EventArgs e) => GetProductDeterm();
    }
}