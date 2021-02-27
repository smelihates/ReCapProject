using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using System.IO;
using Business.Constants;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : Controller
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getbyid")]
        public IActionResult GetById(int carImageId)
        {
            var result = _carImageService.GetById(carImageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getimagesbycarid")]
        public IActionResult GetImagesByCarId(int carId)
        {
            var result = _carImageService.GetImagesByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] FileUpload uploadCarImage)
        {

            CarImage carImage = AddCarImage(uploadCarImage);


            var result = _carImageService.Add(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm] FileUpload uploadCarImage)
        {
            CarImage carImage = AddCarImage(uploadCarImage);



            var result = _carImageService.Update(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        private string CreateImageGuid()
        {
            var newImageGuid = Guid.NewGuid() + ".jpeg";

            string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName + @"\Entitiesi\CarImages");

            return $@"{path}\{newImageGuid}";
        }

        private CarImage AddCarImage(FileUpload uploadCarImage)
        {
            if (uploadCarImage.Image.Length > 0)
            {


                if (uploadCarImage.CarId > 0)
                {
                    string path = CreateImageGuid();
                    using (FileStream fileStream = System.IO.File.Create(path))
                    {
                        uploadCarImage.Image.CopyTo(fileStream);
                        fileStream.Flush();
                    }
                    CarImage carImage = new CarImage();

                    carImage.CarId = uploadCarImage.CarId;
                    carImage.ImagePath = path;
                    carImage.Date = DateTime.Now;
                    carImage.Id = uploadCarImage.Id;

                    return carImage;

                }
                return null;

            }
            return null;

        }
    }
}
