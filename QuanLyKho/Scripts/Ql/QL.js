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

/* Bắt sự kiện click đơn giá sắp xếp giảm/tăng dần theo giá*/
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
/*bắt sự kiện xóa các mục đã chọn bangr nhân viên*/
$('#deleteSelectedNV').click(function () {
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
/*bắt sự kiện xóa các mục đã chọn bảng sản phẩm*/
$('#deleteSelectedSP').click(function () {
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
/*bắt sự kiện xóa các mục đã chọn bảng nhom sản phẩm*/
$('#deleteSelectedNSP').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/NHOMSANPHAMs/DeleteSelected',
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
/*bắt sự kiện xóa các mục đã chọn bảng chức vụ*/
$('#deleteSelectedCV').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/CHUCVUs/DeleteSelected',
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

/*bắt sự kiện xóa các mục đã chọn bảng kho hàng*/
$('#deleteSelectedKH').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/KHOHANGs/DeleteSelected',
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

/*bắt sự kiện xóa các mục đã chọn bảng vị trí kho hàng*/
$('#deleteSelectedVTK').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/VITRIKHOes/DeleteSelected',
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

/*bắt sự kiện xóa các mục đã chọn bảng vị trí Sản Phẩm*/
$('#deleteSelectedVTSP').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/VITRISPs/DeleteSelected',
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

/*bắt sự kiện xóa các mục đã chọn bảng nha cung cap*/
$('#deleteSelectedNCC').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/NHACUNGCAPs/DeleteSelected',
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
/*bắt sự kiện xóa các mục đã chọn bảng phieu nhap kho*/
$('#deleteSelectedPNK').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/PHIEUNHAPKHOes/DeleteSelected',
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

/*bắt sự kiện xóa các mục đã chọn bảng  ct phieu nhap kho*/
$('#deleteSelectedCTPNK').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/CTPHIEUNHAPKHOes/DeleteSelected',
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

/*bắt sự kiện xóa các mục đã chọn bảng phieu xuat kho*/
$('#deleteSelectedPXK').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/PHIEUXUATKHOes/DeleteSelected',
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

/*bắt sự kiện xóa các mục đã chọn ct bảng phieu xuat kho*/
$('#deleteSelectedCTPXK').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/CTPHIEUXUATKHOes/DeleteSelected',
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
/*bắt sự kiện xóa các mục đã chọn bảng don hang*/
$('#deleteSelectedDH').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/DONHANGs/DeleteSelected',
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
/*bắt sự kiện xóa các mục đã chọn bảng ct don hang*/
$('#deleteSelectedCTDH').click(function () {
    var selectedIds = $('.checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedIds.length === 0) {
        alert('Vui lòng chọn ít nhất một mục để xóa.');
    } else {
        var confirmed = confirm('Bạn có chắc muốn xóa các mục đã chọn?');

        if (confirmed) {
            $.ajax({
                url: '/CHITIETDONHANGs/DeleteSelected',
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

/*chọn tất cả */
$(document).ready(function () {
    // Xử lý sự kiện khi checkbox "check all" được chọn/deselect
    $('#checkAll').change(function () {
        var isChecked = $(this).is(':checked');
        $('.checkbox').prop('checked', isChecked);
    });
});
/*tim kiem*/
$(document).ready(function () {
    $('#search').keyup(function () {
        var searchText = $(this).val().toLowerCase();
        $('tbody.search tr').each(function () {
            var currentRowText = $(this).text().toLowerCase();
            if (currentRowText.indexOf(searchText) !== -1) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });
    });
});
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
