using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_hoadon.Models;

namespace webapi_hoadon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        [HttpGet]
        public IActionResult getDSHanghoa()
        {
            try
            {
                QLHDContext db = new QLHDContext();
                List<CHanghoa> ds = db.Hanghoas.Select(t => CHanghoa.chuyendoi(t)).ToList();
                return Ok(ds);
            }
            catch (Exception) {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public IActionResult getHanghoa(string id)
        {
            try
            {
                QLHDContext db = new QLHDContext();
                Hanghoa a = db.Hanghoas.Find(id);
                if (a == null)
                    return NotFound();
                return Ok(CHanghoa.chuyendoi(a));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("mahang")]
        public IActionResult getDSHanghoa(string id)
        {
            try
            {
                QLHDContext db = new QLHDContext();
                List<CHanghoa> ds = db.Hanghoas.Where(t=>t.Mahang.Contains(id)).Select(k=>CHanghoa.chuyendoi(k)).ToList();
                return Ok(ds);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult themHangHoa(CHanghoa x)
        {
            try
            {
                QLHDContext db = new QLHDContext();
                Hanghoa a = CHanghoa.chuyendoi(x);
                db.Hanghoas.Add(a);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public IActionResult suaHanghoa(CHanghoa x)
        {
            try
            {
                QLHDContext db = new QLHDContext();
                Hanghoa a = db.Hanghoas.Find(x.Mahang);
                if (a == null)
                    return NotFound();
                a.Tenhang = x.Tenhang;
                a.Dvt = x.Dvt;
                a.Dongia = x.Dongia;
                db.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult xoaHanghoa(string id)
        {
            try
            {
                QLHDContext db = new QLHDContext();
                Hanghoa a = db.Hanghoas.Find(id);
                if (a == null)
                    return NotFound();
                db.Hanghoas.Remove(a);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
    