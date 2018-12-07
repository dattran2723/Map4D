var array = [
    {
        img: "/Content/Client/img/man-one.jpg",
        name: "Nguyễn Văn Linh",
        cmt: "Tính năng rất hữu ích và tiện dụng đối với tài xế chúng tôi"
    },
    {
        img: "/Content/Client/img/man-one.jpg",
        name: "Trần Văn Duy",
        cmt: "Chúng tôi đặc biệt ấn tượng với chức năng hiển thị bản đồ theo thời gian"
    },
    {
        img: "/Content/Client/img/man-one.jpg",
        name: "Mr Robbert",
        cmt: '"It is amazing"'
    },
    {
        img: "/content/client/img/man-one.jpg",
        name: "Nguyễn Thanh Hương",
        cmt: "Map4d thể hiện đầy đủ các công nghệ hiện đại từ không gian ảo tới hình ảnh thực tế được xây dựng trên nền tảng 3d"
    },
    {
        img: "/content/client/img/man-one.jpg",
        name: "Trần Văn Qúy",
        cmt: '"Good plans.awesome work"'
    },
    {
        img: "/content/client/img/man-one.jpg",
        name: "Nguyễn Đăng Tài Hoa",
        cmt: '"Good plans.awesome work"'
    },
]
for (var i = 0; i < array.length; i++) {
    $('.boxBuild#' + i + ' img').attr("src", array[i].img);
    $('.boxBuild#' + i + ' h5').html(array[i].name);
    $('.boxBuild#' + i + ' p').html(array[i].cmt);

}