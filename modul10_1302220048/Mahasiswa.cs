namespace modul10_1302220048
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }

        public List<String> Course { get; set; }

        public int Year { get; set; }   
        public Mahasiswa(string nama, string nim, List<String> course , int year )
        {
            this.Nama = nama;
            this.Nim = nim;
            this.Course = course;
            this.Year = year;
        }


    }
}
