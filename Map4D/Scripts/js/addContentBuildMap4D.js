var array = [
    {
        img: "/Content/Client/img/product2.jpg",
        name: "Nguyễn Văn Linh",
        cmt: "Tính năng rất hữu ích và tiện dụng đối với tài xế chúng tôi"
    },
    {
        img: "/Content/Client/img/Customer1.png",
        name: "Trần Văn Duy",
        cmt: "Chúng tôi đặc biệt ấn tượng với chức năng hiển thị bản đồ theo thời gian"
    },
    {
        img: "/Content/Client/img/Customer3.png",
        name: "Mr Robbert",
        cmt: '"It is amazing"'
    },
    {
        img: "/content/client/img/Customer2.png",
        name: "Nguyễn Thanh Hương",
        cmt: 'Map4d thể hiện đầy đủ các công nghệ hiện đại từ không gian ảo tới hình ảnh'
    },
    {
        img: "/content/client/img/Customer4.png",
        name: "Trần Văn Qúy",
        cmt: '"Good plans.awesome work"'
    },
    {
        img: "/content/client/img/product2.jpg",
        name: "Nguyễn Đăng Tài Hoa",
        cmt: '"Good plans.awesome work"'
    },
]
for (var i = 0; i < array.length; i++) {
    $('.boxBuild#' + i + ' img').attr("src", array[i].img);
    $('.boxBuild#' + i + ' h5').html(array[i].name);
    $('.boxBuild#' + i + ' p').html(array[i].cmt);

}