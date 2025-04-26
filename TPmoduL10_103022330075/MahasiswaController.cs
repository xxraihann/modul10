using Microsoft.AspNetCore.Mvc;
using TPmoduL10_103022330075; 
using System.Collections.Generic;
using TPmoduL10_103022330075;

namespace WebApiMahasiswa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static readonly List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Raihan Ananda Putra", Nim = "133022330075" },
            new Mahasiswa { Nama = "Intan Nur Aini", Nim = "13302233" },
            new Mahasiswa { Nama = "Gumi", Nim = "13302233" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return daftarMahasiswa;
        }
    }
}
