using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWarehouse
{
    public class Constant
    {
        public const string ETL_SUKSES = "success";
        public const string ETL_FAILURE = "failure";

        public const string TABEL_AREA = "DimArea";
        public const string TABEL_BARANG_BAHAN = "DimBarangBahan";
        public const string TABEL_HAMA = "DimHama";
        public const string TABEL_LAHAN = "DimLahan";
        public const string TABEL_NYIANG = "DimNyiang";
        public const string TABEL_PANGKAS = "DimPangkas";
        public const string TABEL_PEMETIKAN = "DimPemetikan";
        public const string TABEL_PUPUK = "DimPupuk";
        public const string TABEL_TANAH = "DimTanah";
        public const string TABEL_WAKTU = "DimWaktu";

        public const string TABEL_FACT_AREA_PRODUKSI = "FactAreaProduksi";
        public const string TABEL_FACT_BARANG_BAHAN = "FactBarangBahan";
        public const string TABEL_FACT_CURAH_HUJAN = "FactCurahHujan";
        public const string TABEL_FACT_DAWUNGAN = "FactDawungan";
        public const string TABEL_FACT_FUNGISIDA_PENYAKIT = "FactFungisidaPenyakit";
        public const string TABEL_FACT_INTEKSIDA_HAMA = "FactInteksidaHama";
        public const string TABEL_FACT_KONSENSI = "FactKonsensi";
        public const string TABEL_FACT_PEMANGKASAN = "FactPemangkasan";
        public const string TABEL_FACT_PEMUPUKAN = "FactPemupukan";
        public const string TABEL_FACT_PENGENDALIAN_HAMA = "FactPengendalianHama";
        public const string TABEL_FACT_PENGENDALIAN_PENYAKIT = "FactPengendalianPenyakit";
        public const string TABEL_FACT_PENYIANGAN = "FactPenyiangan";
        public const string TABEL_FACT_PRODUKSI = "FactProduksi";
        public const string TABEL_FACT_SEMPROT_HAMA = "FactSemprotHama";
        public const string TABEL_FACT_SEMPROT_PENYAKIT = "FactSemprotPenyakit";
        public const string TABEL_FACT_SERANGAN_HAMA = "FactSeranganHama";
        public const string TABEL_FACT_SERANGAN_PENYAKIT = "FactSeranganPenyakit";
        public const string TABEL_FACT_TARGET_PRODUKSI = "FactTargetProduksi";

        public const string DIMENSI_SELECTED = "dimensi";
        public const string FAKTA_SELECTED = "fakta";
        public const string OLAP_SELECTED = "olap";
    }
}
