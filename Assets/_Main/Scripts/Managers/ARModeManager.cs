using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MonsterAR.Utility;

public class ARModeManager : Singleton<ARModeManager>
{
    [Header("Main")]    
    [SerializeField] private GameObject arModeImageTargetHolder;
    private int imageTargetIndex;

    private List<ARMateri> arMateri = new List<ARMateri>();
        
    [SerializeField] private AudioClip[] infoAudioClips;

    [SerializeField] private Material photoMaterial;

    [SerializeField] private Texture[] photoTextures;

    [Header("UI")]
    [SerializeField] private GameObject arModeFooterToolHolder;
    // [SerializeField] private Text titleText;
    // [SerializeField] private Text materiText;
    
    
            
    void Start()
    {
        // AssignARMateri();
    }

    public void SetARMateri(int index){
        imageTargetIndex = index;
        
        // titleText.text = arMateri[index].GetTitle();
        // materiText.text = arMateri[index].GetDescription();
        // infoAudioSource.clip = infoAudioClips[index];
        // photoMaterial.SetTexture("_MainTex", photoTextures[index]);
                
    }

    
    public void ActivateMode(){
        arModeImageTargetHolder.SetActive(true);
        arModeFooterToolHolder.SetActive(true);
        
    }

    public void DeActivateMode(){
        arModeImageTargetHolder.SetActive(false);
        arModeFooterToolHolder.SetActive(false);
    }

    void AssignARMateri(){
        arMateri.Add( new ARMateri(
            "Museum Bank Indonesia",
            " Museum Bank Indonesia adalah sebuah museum di Jakarta, Indonesia yang terletak di Jl. Pintu Besar Utara No.3, Jakarta Barat (depan stasiun Beos Kota), dengan menempati area bekas gedung Bank Indonesia Kota yang merupakan cagar budaya peninggalan De Javasche Bank yang beraliran neo-klasikal, dipadu dengan pengaruh lokal, dan dibangun pertama kali pada tahun 1828.\n \n Pada tahun 1625, di tempat ini pernah dibangun sebuah gereja sederhana untuk umat Protestan. Pada tahun 1628, gereja ini dibongkar karena digunakan untuk tempat meriam besar ketika puluhan ribu tentara Sultan Agung menyerang Batavia untuk pertama kali.\n \n Museum ini menyajikan informasi peran Bank Indonesia dalam perjalanan sejarah bangsa yang dimulai sejak sebelum kedatangan bangsa barat di Nusantara hingga terbentuknya Bank Indonesia pada tahun 1953 dan kebijakan-kebijakan Bank Indonesia, meliputi pula latar belakang dan dampak kebijakan Bank Indonesia bagi masyarakat sampai dengan tahun 2005. Penyajiannya dikemas sedemikian rupa dengan memanfaatkan teknologi modern dan multi media, seperti display elektronik, panel statik, televisi plasma, dan diorama sehingga menciptakan kenyamanan pengunjung dalam menikmati Museum Bank Indonesia. Selain itu terdapat pula fakta dan koleksi benda bersejarah pada masa sebelum terbentuknya Bank Indonesia, seperti pada masa kerajaan-kerajaan Nusantara, antara lain berupa koleksi uang numismatik yang ditampilkan juga secara menarik.\n \n Peresmian Museum Bank Indonesia dilakukan melalui dua tahap, yaitu peresmian tahap I dan mulai dibuka untuk masyarakat (soft opening) pada tanggal 15 Desember 2006 oleh Gubernur Bank Indonesia saat itu, Burhanuddin Abdullah, dan peresmian tahap II (grand opening) oleh Presiden RI Susilo Bambang Yudhoyono, pada tanggal 21 Juli 2009.\n \n Museum Bank Indonesia buka setiap hari kecuali Senin dan hari libur nasional.\n"
        ));
        arMateri.Add( new ARMateri(
            "Proklamasi",
            " Proklamasi Kemerdekaan Indonesia dilaksanakan pada hari Jumat, 17 Agustus 1945 tahun Masehi, atau tanggal 17 Agustus 2605 menurut tahun Jepang, yang dibacakan oleh Soekarno dengan didampingi oleh Drs. Mohammad Hatta bertempat di Jalan Pegangsaan Timur 56, Jakarta Pusat.\n \n Kata-kata dan deklarasi proklamasi tersebut harus menyeimbangkan kepentingan kepentingan internal Indonesia dan Jepang yang saling bertentangan pada saat itu. Proklamasi tersebut menandai dimulainya perlawanan diplomatik dan bersenjata dari Revolusi Nasional Indonesia, yang berperang melawan pasukan Belanda dan warga sipil pro-Belanda, hingga Belanda secara resmi mengakui kemerdekaan Indonesia pada tahun 1949. Pada tahun 2005, Belanda menyatakan bahwa mereka telah memutuskan untuk menerima secara de facto tanggal 17 Agustus 1945 sebagai tanggal kemerdekaan Indonesia. Namun, pada tanggal 14 September 2011, pengadilan Belanda memutuskan dalam kasus pembantaian Rawagede bahwa Belanda bertanggung jawab karena memiliki tugas untuk mempertahankan penduduknya, yang juga mengindikasikan bahwa daerah tersebut adalah bagian dari Hindia Timur Belanda, bertentangan dengan klaim Indonesia atas 17 Agustus 1945 sebagai tanggal kemerdekaannya. Dalam sebuah wawancara tahun 2013, sejarawan Indonesia Sukotjo, antara lain, meminta pemerintah Belanda untuk secara resmi mengakui tanggal kemerdekaan pada 17 Agustus 1945. Perserikatan Bangsa-Bangsa mengakui tanggal 27 Desember 1949 sebagai tanggal kemerdekaan Indonesia.\n \n Naskah proklamasi ditandatangani oleh Sukarno (yang menuliskan namanya sebagai 'Soekarno' menggunakan ortografi Belanda) dan Mohammad Hatta, yang kemudian ditunjuk sebagai presiden dan wakil presiden berturut-turut sehari setelah proklamasi dibacakan.\n \n Hari Kemerdekaan dijadikan sebagai hari libur nasional melalui keputusan pemerintah yang dikeluarkan pada 18 Juni 1946.\n \n "
        ));
        arMateri.Add( new ARMateri(
            "NKRI",
            " Republik Indonesia (RI) atau Negara Kesatuan Republik Indonesia (NKRI), atau lebih umum disebut Indonesia, adalah negara di Asia Tenggara yang dilintasi garis khatulistiwa dan berada di antara daratan benua Asia dan Australia, serta antara Samudra Pasifik dan Samudra Hindia. Indonesia adalah negara kepulauan terbesar di dunia yang terdiri dari 17.504 pulau. Nama alternatif yang biasa dipakai adalah Nusantara. Dengan populasi Hampir 270.054.853 jiwa pada tahun 2018, Indonesia adalah negara berpenduduk terbesar keempat di dunia dan negara yang berpenduduk Muslim terbesar di dunia, dengan lebih dari 230 juta jiwa.\n \n Bentuk negara Indonesia adalah negara kesatuan dan bentuk pemerintahan Indonesia adalah republik, dengan Dewan Perwakilan Rakyat, Dewan Perwakilan Daerah dan Presiden yang dipilih secara langsung.\n \n Ibu kota negara Indonesia adalah Jakarta. Indonesia berbatasan darat dengan Malaysia di Pulau Kalimantan, dengan Papua Nugini di Pulau Papua dan dengan Timor Leste di Pulau Timor. Negara tetangga lainnya adalah Singapura, Filipina, Australia, dan wilayah persatuan Kepulauan Andaman dan Nikobar di India.\n \n Sejarah Indonesia banyak dipengaruhi oleh bangsa lainnya. Kepulauan Indonesia menjadi wilayah perdagangan penting sejak abad ke-7, yaitu sejak berdirinya Kerajaan Sriwijaya, sebuah kemaharajaan Hindu-Buddha yang berpusat di Palembang. Kerajaan Sriwijaya ini menjalin hubungan agama dan perdagangan dengan Tiongkok dan India, juga dengan bangsa Arab. Kerajaan-kerajaan beragama Hindu dan/atau Buddha mulai tumbuh pada awal abad ke-4 hingga abad ke-13 Masehi, diikuti para pedagang dan ulama dari jazirah Arab yang membawa agama Islam sekitar abad ke-8 hingga abad ke-16, serta kedatangan bangsa Eropa pada akhir abad ke-15 yang saling bertempur untuk memonopoli perdagangan rempah-rempah Maluku semasa era penjelajahan samudra. Setelah berada di bawah penjajahan Belanda selama hampir 3 abad, Indonesia yang saat itu bernama Hindia Belanda menyatakan kemerdekaannya di akhir Perang Dunia II, tepatnya tanggal 17 Agustus 1945. Selanjutnya, Indonesia mendapat berbagai tantangan dan persoalan berat, mulai dari seringnya terjadi bencana alam, praktik korupsi yang masif, konflik sosial, gerakan separatisme, proses demokratisasi, dan periode pembangunan, perubahan dan perkembangan sosial-ekonomi-politik, serta modernisasi yang pesat.\n \n Dari Sabang di ujung Aceh sampai Merauke di tanah Papua, Indonesia terdiri dari berbagai suku bangsa, bahasa, dan agama. Berdasarkan rumpun bangsa (ras), Indonesia terdiri atas bangsa asli pribumi yakni Mongoloid Selatan/Austronesia dan Melanesia di mana bangsa Austronesia yang terbesar jumlahnya dan lebih banyak mendiami Indonesia bagian barat. Secara lebih spesifik, suku bangsa Jawa adalah suku bangsa terbesar dengan populasi mencapai 41,7% dari seluruh penduduk Indonesia. Semboyan nasional Indonesia, 'Bhinneka tunggal ika' ('Berbeda-beda namun tetap satu'), bermakna keberagaman sosial-budaya yang membentuk satu kesatuan/negara. Selain memiliki populasi penduduk yang padat dan wilayah yang luas, Indonesia memiliki wilayah alam yang mendukung tingkat keanekaragaman hayati terbesar kedua di dunia.\n \n Indonesia merupakan anggota dari PBB dan satu-satunya anggota yang pernah keluar dari PBB, yaitu pada tanggal 7 Januari 1965, dan bergabung kembali pada tanggal 28 September 1966 dan Indonesia tetap dinyatakan sebagai anggota yang ke-60, keanggotaan yang sama sejak bergabungnya Indonesia pada tanggal 28 September 1950. Selain PBB, Indonesia juga negara anggota dari organisasi ASEAN, KAA, APEC, OKI, G-20 dan sebentar lagi akan menjadi anggota OECD.\n \n "
        ));
        arMateri.Add( new ARMateri(
            "Kemerdekaan",
            " Sejarah adalah salah satu mata pelajaran yang wajib untuk kita ketahui dan pelajari ilmunya. Salah satunya adalah sejarah Bangsa Indonesia. Negara yang terkenal dengan sejarahnya akan penjajahan dari negara asing itu ternyata memiliki masa lalu yang bisa dijadikan sebagai bahan ilmu pengetahuan.\n \n Kemerdekaan indonesia memang dikenal sebagai salah satu tragedi kebangsaan yang sangat membutuhkan perjuangan dan memiliki masa lalu yang bisa dijadikan sebagai bahan ilmu pengetahuan. Makna dan artinya sangat besar bagi masyarakat Indonesia dengan banyak mengorbankan para pahlawan yang ikut berjuang.\n \n Dengan mengingat kejadian sejarah tersebut, rasa nasionalisme kita terhadap Bangsa Indonesia akan semakin bertambah. Banyak sekali peristiwa-peristiwa yang melatarbelakangi sejarah kemerdekaan Indonesia.\n \n Misalnya saja peristiwa proklamasi kemerdekaan Indonesia, peristiwa G30/S/PKI, peristiwa Rengasdengklok, dan masih banyak peristiwa-peristiwa lainnya. Untuk itu dalam pembahasan kali ini akan dijelaskan beberapa sejarah dan peristiwa kemerdekaan Indonesia.\n \n "
        ));
        
    }
}
