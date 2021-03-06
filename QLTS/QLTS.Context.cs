//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class QLEntities : DbContext
    {
        public QLEntities()
            : base("name=QLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<THISINH> THISINHs { get; set; }
        public DbSet<HUYEN> HUYENs { get; set; }
    
        public virtual ObjectResult<THISINH_SelectAll_Result> THISINH_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<THISINH_SelectAll_Result>("THISINH_SelectAll");
        }
    
        public virtual int THISINH_Delete(string mahs)
        {
            var mahsParameter = mahs != null ?
                new ObjectParameter("mahs", mahs) :
                new ObjectParameter("mahs", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THISINH_Delete", mahsParameter);
        }
    
        public virtual int THISINh_Insert(string mahs, string hoten, Nullable<System.DateTime> ngaysinh, Nullable<bool> gioitinh, string sbd, string sdt, string mahuyen, string matinh, string matruong, string manganh, string makvut, string madtut)
        {
            var mahsParameter = mahs != null ?
                new ObjectParameter("mahs", mahs) :
                new ObjectParameter("mahs", typeof(string));
    
            var hotenParameter = hoten != null ?
                new ObjectParameter("hoten", hoten) :
                new ObjectParameter("hoten", typeof(string));
    
            var ngaysinhParameter = ngaysinh.HasValue ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(System.DateTime));
    
            var gioitinhParameter = gioitinh.HasValue ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(bool));
    
            var sbdParameter = sbd != null ?
                new ObjectParameter("sbd", sbd) :
                new ObjectParameter("sbd", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var mahuyenParameter = mahuyen != null ?
                new ObjectParameter("mahuyen", mahuyen) :
                new ObjectParameter("mahuyen", typeof(string));
    
            var matinhParameter = matinh != null ?
                new ObjectParameter("matinh", matinh) :
                new ObjectParameter("matinh", typeof(string));
    
            var matruongParameter = matruong != null ?
                new ObjectParameter("matruong", matruong) :
                new ObjectParameter("matruong", typeof(string));
    
            var manganhParameter = manganh != null ?
                new ObjectParameter("manganh", manganh) :
                new ObjectParameter("manganh", typeof(string));
    
            var makvutParameter = makvut != null ?
                new ObjectParameter("makvut", makvut) :
                new ObjectParameter("makvut", typeof(string));
    
            var madtutParameter = madtut != null ?
                new ObjectParameter("madtut", madtut) :
                new ObjectParameter("madtut", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THISINh_Insert", mahsParameter, hotenParameter, ngaysinhParameter, gioitinhParameter, sbdParameter, sdtParameter, mahuyenParameter, matinhParameter, matruongParameter, manganhParameter, makvutParameter, madtutParameter);
        }
    
        public virtual int THISINH_Update(string mahss, string hotens, Nullable<System.DateTime> ngaysinhs, Nullable<bool> gioitinhs, string sbds, string sdts, string mahuyens, string matinhs, string matruongs, string manganhs, string makvuts, string madtuts)
        {
            var mahssParameter = mahss != null ?
                new ObjectParameter("mahss", mahss) :
                new ObjectParameter("mahss", typeof(string));
    
            var hotensParameter = hotens != null ?
                new ObjectParameter("hotens", hotens) :
                new ObjectParameter("hotens", typeof(string));
    
            var ngaysinhsParameter = ngaysinhs.HasValue ?
                new ObjectParameter("ngaysinhs", ngaysinhs) :
                new ObjectParameter("ngaysinhs", typeof(System.DateTime));
    
            var gioitinhsParameter = gioitinhs.HasValue ?
                new ObjectParameter("gioitinhs", gioitinhs) :
                new ObjectParameter("gioitinhs", typeof(bool));
    
            var sbdsParameter = sbds != null ?
                new ObjectParameter("sbds", sbds) :
                new ObjectParameter("sbds", typeof(string));
    
            var sdtsParameter = sdts != null ?
                new ObjectParameter("sdts", sdts) :
                new ObjectParameter("sdts", typeof(string));
    
            var mahuyensParameter = mahuyens != null ?
                new ObjectParameter("mahuyens", mahuyens) :
                new ObjectParameter("mahuyens", typeof(string));
    
            var matinhsParameter = matinhs != null ?
                new ObjectParameter("matinhs", matinhs) :
                new ObjectParameter("matinhs", typeof(string));
    
            var matruongsParameter = matruongs != null ?
                new ObjectParameter("matruongs", matruongs) :
                new ObjectParameter("matruongs", typeof(string));
    
            var manganhsParameter = manganhs != null ?
                new ObjectParameter("manganhs", manganhs) :
                new ObjectParameter("manganhs", typeof(string));
    
            var makvutsParameter = makvuts != null ?
                new ObjectParameter("makvuts", makvuts) :
                new ObjectParameter("makvuts", typeof(string));
    
            var madtutsParameter = madtuts != null ?
                new ObjectParameter("madtuts", madtuts) :
                new ObjectParameter("madtuts", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THISINH_Update", mahssParameter, hotensParameter, ngaysinhsParameter, gioitinhsParameter, sbdsParameter, sdtsParameter, mahuyensParameter, matinhsParameter, matruongsParameter, manganhsParameter, makvutsParameter, madtutsParameter);
        }
    
        public virtual int HUYEN_Delete(string mahuyen1)
        {
            var mahuyen1Parameter = mahuyen1 != null ?
                new ObjectParameter("mahuyen1", mahuyen1) :
                new ObjectParameter("mahuyen1", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HUYEN_Delete", mahuyen1Parameter);
        }
    
        public virtual int HUYEN_Insert(string mahuyen, string tenhuyen, string matinh)
        {
            var mahuyenParameter = mahuyen != null ?
                new ObjectParameter("mahuyen", mahuyen) :
                new ObjectParameter("mahuyen", typeof(string));
    
            var tenhuyenParameter = tenhuyen != null ?
                new ObjectParameter("tenhuyen", tenhuyen) :
                new ObjectParameter("tenhuyen", typeof(string));
    
            var matinhParameter = matinh != null ?
                new ObjectParameter("matinh", matinh) :
                new ObjectParameter("matinh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HUYEN_Insert", mahuyenParameter, tenhuyenParameter, matinhParameter);
        }
    
        public virtual ObjectResult<HUYEN_SelectAll_Result> HUYEN_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HUYEN_SelectAll_Result>("HUYEN_SelectAll");
        }
    
        public virtual int HUYEN_Update(string mahuyen2, string tenhuyen2, string matinh2)
        {
            var mahuyen2Parameter = mahuyen2 != null ?
                new ObjectParameter("mahuyen2", mahuyen2) :
                new ObjectParameter("mahuyen2", typeof(string));
    
            var tenhuyen2Parameter = tenhuyen2 != null ?
                new ObjectParameter("tenhuyen2", tenhuyen2) :
                new ObjectParameter("tenhuyen2", typeof(string));
    
            var matinh2Parameter = matinh2 != null ?
                new ObjectParameter("matinh2", matinh2) :
                new ObjectParameter("matinh2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HUYEN_Update", mahuyen2Parameter, tenhuyen2Parameter, matinh2Parameter);
        }
    }
}
