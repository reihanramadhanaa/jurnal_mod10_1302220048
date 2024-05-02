using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220048.Controllers
{
   


        [Route("api/[controller]")]
        [ApiController]
        public class MahasiswaController : Controller
        {
            public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Reihan Ramadhana Anwari", "1302220048",["KPL","BASDAT","PBO"],2022),
            new Mahasiswa("Muhammad Rafif AryaSatya Purnomo", "1302220003",["KPL","BASDAT","PBO"],2022),
            new Mahasiswa("Muhammad Ghaziveda Belvanaufal", "1302220011",["KPL","BASDAT","PBO"],2022),
            new Mahasiswa("Daffa Adrianto Effendi", "1302220151",["KPL","BASDAT","PBO"],2022),
            new Mahasiswa("Mochammad Rizky Septian", "1302220121",["KPL","BASDAT","PBO"],2022),
            new Mahasiswa("Muhammad Ghiyats Fatiha", "1302220109",["KPL","BASDAT","PBO"],2022),
            new Mahasiswa("Muhammad Zidan Siva Fajar", "1302223039",["KPL","BASDAT","PBO"],2022)
        };

            [HttpGet]
            public IEnumerable<Mahasiswa> Get()
            {
                return dataMahasiswa;
            }


            [HttpGet("{id}")]
            public Mahasiswa Get(int id)
            {
                return dataMahasiswa[id];
            }


            [HttpPost]
            public void Post([FromBody] Mahasiswa value)
            {
                dataMahasiswa.Add(value);
            }

            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                dataMahasiswa.RemoveAt(id);
            }
        }

    }

