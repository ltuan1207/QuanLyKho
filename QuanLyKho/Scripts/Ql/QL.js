$(document).ready(function () {
    $('#sort-asc').on('click', function () {
        var url = '@Url.Action("Index", "SANPHAMs", new { sortOrder = "asc" })';
        window.location.href = url;
    });
    $('#sort-desc').on('click', function () {
        var url = '@Url.Action("Index", "SANPHAMs", new { sortOrder = "desc" })';
        window.location.href = url
    });
});

$(document).ready(function () {
    $('#sort-price-asc').on('click', function () {
        var url = '@Url.Action("Index", "SanPham", new { sortOrder = "__sortOrder__", filterStock = ViewBag.FilterStock, filterPrice = ViewBag.FilterPrice })';
        url = url.replace("__sortOrder__", "asc");
        window.location.href = url;
    });
    $('#sort-price-desc').on('click', function () {
        var url = '@Url.Action("Index", "SanPham", new { sortOrder = "__sortOrder__", filterStock = ViewBag.FilterStock, filterPrice = ViewBag.FilterPrice })';
        url = url.replace("__sortOrder__", "desc");
        window.location.href = url;
    });
});

$('#deleteSelected').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/NHANVIENs/DeleteSelected',
                type: 'POST',
                data: { selectedIds: selectedIds },
                success: function () {
                    location.reload();
                },
                error: function () {
                    alert('Đã xảy ra lỗi khi xóa các mục đã chọn.');
                }
            });
        }
    }
});

$('#deleteSelected').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/SANPHAMs/DeleteSelected',
                type: 'POST',
                data: { selectedIds: selectedIds },
                success: function () {
                    location.reload();
                },
                error: function () {
                    alert('Đã xảy ra lỗi khi xóa các mục đã chọn.');
                }
            });
        }
    }
});

$(document).ready(function () {
    // Xử lý sự kiện khi checkbox "check all" được chọn/deselect
    $('#checkAll').change(function () {
        var isChecked = $(this).is(':checked');
        $('.checkbox').prop('checked', isChecked);
    });
});