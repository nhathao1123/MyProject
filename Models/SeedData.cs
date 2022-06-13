using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace MyProject.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BooksStoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BooksStoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                new Book
                {
                    Title = "Honda Civic 1.5 G 2022 - 770 triệu  ",

                    Description = "Khối động cơ 1.5L Vtecturbo được trang bị trên cả 3 phiên bản. Trang bị hệ thống hỗ trợ an toàn tiên tiến Honda Sensing. Camera hỗ trợ quan sát làn đường Lanewatch.  ",

                    Genre = "Honda Civic 1.5 G 2022 ",
                    Price = 11.98m
                },
                new Book
                {
                    Title = "BMW 430i M Sport 2022 - 3 tỉ 199 triệu",
                    Description = "Gây chú ý bởi thiết kế mới, gợi cảm và táo bạo hơn với lưới tản nhiệt hình quả thận cỡ lớn được mạ chrome ấn tượng. Đèn pha Led thích ứng với công nghệ chiếu sáng hình lục giác và tích hợp đèn laser, BMW 430i Gran Coupe M Sport mang lại vẻ ngoài ấn tượng thể thao khó có thể nhầm lẫn.",

                    Genre = "BMW 430i M Sport  ",
                    Price = 17.46m
                },
                new Book
                {
                    Title = "Honda HR-V 2023",
                    Description = "e được trang bị động cơ với công suất 158 mã lực và mô-men xoắn cực đại 187 Nm, cao hơn 17 và 11 so với HR-V hiện tại. Điều đó có nghĩa là hiệu suất hoạt động mạnh mẽ hơn.",

                    Genre = "Honda HR-V",
                    Price = 13.41m
                },
                new Book
                {
                    Title = "VinFast XEđiện EVS35",
                    Description = "Đặc biệt, thông qua triển lãm, VinFast sẽ lần đầu tiên ra mắt người tiêu dùng châu Âu 2 mẫu SUV điện cao cấp VF 8 và VF 9. Tại đây, khách hàng có thể trực tiếp chiêm ngưỡng nội, ngoại thất và tìm hiểu các tính năng thông minh được tích hợp trên xe.",
                    Genre = "VinFast XEđiện EVS35",
                    Price = 18.69m
                },
                new Book
                {

                    Title = "Texlar",
                    Description = "Hãng XE điện, tiếp kiệm bảo vệ môi trường , động cơ ss ",

                    Genre = "Texlar",
                    Price = 31.26m
                }
                ); ;
                context.SaveChanges();
            }
        }
    }
}






