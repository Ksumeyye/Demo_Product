﻿using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
//using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;

namespace Demo_Product.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            ProductValidator validationRules=new ProductValidator();
            ValidationResult results = validationRules.Validate(p);
            if (results.IsValid)
            {
                productManager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteProduct(int id)
        {
            var product = productManager.TGetById(id);
            productManager.TDelete(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = productManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            productManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
