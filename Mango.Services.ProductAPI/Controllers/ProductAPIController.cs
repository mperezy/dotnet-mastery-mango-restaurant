using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mango.Services.ProductAPI.Models.Dtos;
using Mango.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    public class ProductAPIController : Controller
    {
        protected RespondeDto _reponse;

        private IProductRepository _productRepository;

        public ProductAPIController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
            this._reponse = new RespondeDto();
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<ProductDto> productDtos = await _productRepository.GetProducts();
                _reponse.Result = productDtos;
            }
            catch (Exception e)
            {
                _reponse.IsSuccess = false;
                _reponse.ErrorMessages = new List<string>() {e.ToString()};
            }

            return _reponse;
        }

        [HttpGet]
        [Route("{productId}")]
        public async Task<object> Get(int productId)
        {
            try
            {
                ProductDto productDto = await _productRepository.GetProductByid(productId);
                _reponse.Result = productDto;
            }
            catch (Exception e)
            {
                _reponse.IsSuccess = false;
                _reponse.ErrorMessages = new List<string>() {e.ToString()};
            }

            return _reponse;
        }

        [HttpPost]
        public async Task<object> Post([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto _productDto = await _productRepository.CreateUpdateProduct(productDto);
                _reponse.Result = _productDto;
            }
            catch (Exception e)
            {
                _reponse.IsSuccess = false;
                _reponse.ErrorMessages = new List<string>() {e.ToString()};
            }

            return _reponse;
        }

        [HttpPut]
        public async Task<object> Put([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto _productDto = await _productRepository.CreateUpdateProduct(productDto);
                _reponse.Result = _productDto;
            }
            catch (Exception e)
            {
                _reponse.IsSuccess = false;
                _reponse.ErrorMessages = new List<string>() {e.ToString()};
            }

            return _reponse;
        }

        [HttpDelete]
        [Route("{productId}")]
        public async Task<object> Delete(int productId)
        {
            try
            {
                bool isSuccess = await _productRepository.DeleteProduct(productId);
                _reponse.Result = isSuccess;
            }
            catch (Exception e)
            {
                _reponse.IsSuccess = false;
                _reponse.ErrorMessages = new List<string>() {e.ToString()};
            }

            return _reponse;
        }
    }
}