/*Đăng xuất xóa session*/
$(document).ready(function () {
    $("#logout-btn").click(function () {
        $.ajax({
            type: "POST",
            url: "/Login/Logout",
            success: function () {
                window.location.href = "/Login/Dangnhap";
            },
            error: function () {
                alert("Logout failed.");
            }
        });
    });
});


