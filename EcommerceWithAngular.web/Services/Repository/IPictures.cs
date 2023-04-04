using EcommerceWithAngular.web.Models;

namespace EcommerceWithAngular.web.Services.Repository
{
    public interface IPictures
    {
        Picture GetPictures(int id);

        void insert(Picture picture);
        void update(Picture picture);
        void delete(int id);
        void Count();
        void save();
    }
}
