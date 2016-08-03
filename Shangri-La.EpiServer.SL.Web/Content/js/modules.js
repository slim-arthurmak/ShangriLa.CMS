function initialize() {
    var a, b = new google.maps.LatLngBounds,
        c = new google.maps.LatLng(1.311166, 103.826197),
        d = {
            scrollwheel: !1,
            zoom: 15,
            center: c,
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            styles: [{
                featureType: "landscape",
                stylers: [{
                    hue: "#FFBB00"
                }, {
                    saturation: 43.400000000000006
                }, {
                    lightness: 37.599999999999994
                }, {
                    gamma: 1
                }]
            }, {
                featureType: "road.highway",
                stylers: [{
                    hue: "#FFC200"
                }, {
                    saturation: -61.8
                }, {
                    lightness: 45.599999999999994
                }, {
                    gamma: 1
                }]
            }, {
                featureType: "road.arterial",
                stylers: [{
                    hue: "#FF0300"
                }, {
                    saturation: -100
                }, {
                    lightness: 51.19999999999999
                }, {
                    gamma: 1
                }]
            }, {
                featureType: "road.local",
                stylers: [{
                    hue: "#FF0300"
                }, {
                    saturation: -100
                }, {
                    lightness: 52
                }, {
                    gamma: 1
                }]
            }, {
                featureType: "water",
                stylers: [{
                    hue: "#0078FF"
                }, {
                    saturation: -13.200000000000003
                }, {
                    lightness: 2.4000000000000057
                }, {
                    gamma: 1
                }]
            }, {
                featureType: "poi",
                stylers: [{
                    hue: "#00FF6A"
                }, {
                    saturation: -1.0989010989011234
                }, {
                    lightness: 11.200000000000017
                }, {
                    gamma: 1
                }]
            }]
        };
    a = new google.maps.Map(document.getElementById("google-map"), d);
    var e, f, g = [
            ["Nadaman at Shangri-La Hotel, Singapore", 1.31121, 103.826695, "./img/icons/marker-hotel-shangrila.png"],
            ["Shangri-La Apartment, Singapore", 1.30975, 103.826695, "./img/icons/marker-hotel-shangrila.png"],
            ["Shangri-La hotel, Orange Grove Road, Singapore", 1.31085, 103.826795, "./img/icons/marker-hotel-shangrila.png"],
            ["Hotel Jen Tanglin, Singapore", 1.30431, 103.823843, "./img/icons/marker-hotel-Jen.png"],
            ["Hotel Jen Orchardgateway, Singapore", 1.300595, 103.838787, "./img/icons/marker-hotel-Jen.png"]
    ],
        h = [
            ['<div class="info_content"><h3>Nadaman at Shangri-La Hotel, Singapore</h3></div>'],
            ['<div class="info_content"><h3>Shangri-La Apartment, Singapore</h3></div>'],
            ['<div class="info_content"><h3>Shangri-La hotel, Orange Grove Road, Singapore</h3></div>'],
            ['<div class="info_content"><h3>Hotel Jen Tanglin, Singapore</h3></div>'],
            ['<div class="info_content"><h3>Hotel Jen Orchardgateway, Singapore</h3></div>']
        ],
        i = new google.maps.InfoWindow,
        j = [];
    for (f = 0; f < g.length; f++) {
        var k = new google.maps.LatLng(g[f][1], g[f][2]);
        b.extend(k), e = new google.maps.Marker({
            position: k,
            map: a,
            title: g[f][0],
            icon: g[f][3]
        }), j.push(e)
    }
    $.each(j, function (b, c) {
        google.maps.event.addListener(c, "click", function (b, c) {
            return function () {
                i.setContent(h[c][0]), i.open(a, b)
            }
        }(c, b))
    })
}
Shangrila.anchortag = {
    init: function () {
        this.root = Shangrila, this.bindEvents()
    },
    bindEvents: function () {
        var a = $("#booking-module").outerHeight();
        $(".room-title").on("click", function (b) {
            b.preventDefault();
            var c = $(this).attr("href");
            if ($(c).length) {
                var d = $(c).offset().top - 2 * a;

                Shangrila.scrollToPosition(d);
            }
        })
    }
}, Shangrila.modules.push("anchortag"), Shangrila.banner = {
    init: function () {
        this.root = Shangrila, this.readMoreReset(), this.readMoreCaption(), this.bannerHeight(), this.readMoreLinkCta()
    },
    readMoreReset: function () {
        var a = (this.root, $(".read-more-container"));
        a.each(function () {
            $(this).find(".description").removeAttr("style").find(".moreellipses").remove(), $(this).find(".description").find(".morecontent span").unwrap(), $(this).find(".read-more-droplink").removeClass("icon-ios-arrow-up").addClass("icon-ios-arrow-down").text("Read More")
        })
    },
    readMoreCaption: function () {
        var a = this.root,
            b = 169,
            c = 50;
        a.screenWidth < Shangrila.medium && (b = 142), a.screenWidth < a.extraSmall && (b = 66);
        var d = "...",
            e = $(".read-more-container");
        e.each(function () {
            var a = $(this).find(".read-more-droplink"),
                e = $(this).find(".description").html();
            if (e.length > b) {
                var f = e.substr(0, b),
                    g = e.substr(b, e.length - b),
                    h = f + '<span class="moreellipses">' + d + '&nbsp;</span><span class="morecontent"><span>' + g + "</span></span>";
                $(this).find(".description").html(h), $(this).find(".description").css("height", c)
            } else a.hide()
        })
    },
    readMoreLinkCta: function () {
        var a = $(".read-more-container"),
            b = "Read More",
            c = "Read Less";
        a.each(function () {
            var a = $(this).find(".read-more-droplink"),
                d = 50;
            $(this).find(".description").html();
            a.on("click", function () {
                if ($(this).hasClass("icon-ios-arrow-down")) {
                    $(this).removeClass("icon-ios-arrow-down").addClass("icon-ios-arrow-up"), $(this).parents(".read-more-container").find(".moreellipses").hide(), $(this).parents(".read-more-container").find(".morecontent").slideDown();
                    var a = $(this).parents(".read-more-container").find(".morecontent").height();
                    $(this).parents(".read-more-container").find(".description").animate({
                        height: a + d - 20
                    }), $(this).text(c)
                } else $(this).removeClass("icon-ios-arrow-up").addClass("icon-ios-arrow-down"), $(this).parents(".read-more-container").find(".moreellipses").show(), $(this).parents(".read-more-container").find(".morecontent").stop().hide(), $(this).text(b), $(this).parents(".read-more-container").find(".description").animate({
                    height: d
                })
            })
        })
    },
    bannerHeight: function () {
        var a = (this.root, $(".main-banner-hotel-landing"));
        a.each(function () {
            var a = ($(this).height(), Shangrila.screenHeight),
                b = $("header").height(),
                c = a - b,
                d = $(this).find(".caption-container-hotel-landing").height(),
                e = c - d;
            $(this).css("height", c), Shangrila.small > Shangrila.screenWidth ? Shangrila.screenWidth > Shangrila.screenHeight ? $(this).find(".image-container img").css("height", c) : $(this).find(".image-container img").css("height", e) : $(this).find(".image-container img").css("height", "auto")
        })
    },
    animateArrowCta: function () {
        var a = function (b, c) {
            $(b).css({
                top: "40%"
            }), $(b).animate({
                top: "50%"
            }, {
                duration: c,
                complete: function () {
                    a(this, c)
                }
            })
        };
        a($(".explore-button::before"), 600)
    },
    viewportChange: function () {
        this.readMoreReset(), this.readMoreCaption(), this.bannerHeight()
    }
}, Shangrila.modules.push("banner"), Shangrila.bookingModule = {
    init: function () {
        this.root = Shangrila, this.calendarInit(), this.toolTipBookingModule(), this.addRemoveRooms(), this.openCloseSpecialCode(), this.populateGuestDetails(), this.selectValueCalc(), this.searchHotelsDropPanel(), this.bookingModuleMobile()
    },
    calendarInit: function () {
        this.checkIncheckOut(), this.checkIncheckOutRoomListing()
    },
    checkIncheckOut: function () {
        var a = $(".checkInSelector"),
            b = $(".checkOutSelector"),
            c = {
                minDate: new Date,
                dateFormat: "yy/mm/dd",
                dayNamesMin: ["S", "M", "T", "W", "T", "F", "S"],
                showOptions: {
                    direction: "down"
                },
                beforeShow: function (a, b, c) {
                    var d = ($(".hasDatepicker").parents(".field-container").outerWidth(), $(this)),
                        e = d.parents(".check-status-block").find("#bookingBox");
                    Shangrila.bookingModule.addArrowsCalendar(), d.parents(".booking-panel").hasClass("sticked") || Shangrila.scrollToElement(d, -$("#booking-module").outerHeight() / 2), d.hasClass("checkInSelector") ? e.css({
                        left: 0
                    }) : e.css({
                        left: "auto",
                        right: parseInt($("#ui-datepicker-div").outerWidth())
                    }), $("#ui-datepicker-div").css({
                        position: "absolute",
                        top: 0
                    }), e.append($("#ui-datepicker-div")), $("#ui-datepicker-div").hide()
                },
                onChangeMonthYear: function () {
                    Shangrila.bookingModule.addArrowsCalendar()
                },
                onSelect: function (a) { }
            };
        a.datepicker(c), a.datepicker("setDate", new Date), b.datepicker(c), b.datepicker("setDate", 1)
    },
    checkIncheckOutRoomListing: function () {
        var a = $(".checkInSelectorRooms"),
            b = $(".checkOutSelectorRooms"),
            c = {
                minDate: new Date,
                dateFormat: "yy/mm/dd",
                dayNamesMin: ["S", "M", "T", "W", "T", "F", "S"],
                showOptions: {
                    direction: "down"
                },
                beforeShow: function (a, b, c) {
                    $(".hasDatepicker").parents(".field-container").outerWidth();
                    Shangrila.bookingModule.addArrowsCalendar(), Shangrila.scrollToElement($(this), -$(".room-landing-found-container").outerHeight() / 2 - 150), $(this).hasClass("checkInSelectorRooms") ? $("#ui-datepicker-div").parents("#bookingBoxRooms").css({
                        left: 0
                    }) : $("#ui-datepicker-div").parents("#bookingBoxRooms").css({
                        left: "auto",
                        right: parseInt($("#ui-datepicker-div").outerWidth())
                    }), $("#ui-datepicker-div").css({
                        position: "absolute",
                        top: 0
                    }), $("#bookingBoxRooms").append($("#ui-datepicker-div")), $("#ui-datepicker-div").hide()
                },
                onChangeMonthYear: function () {
                    Shangrila.bookingModule.addArrowsCalendar()
                }
            };
        a.datepicker(c), a.datepicker("setDate", new Date), b.datepicker(c), b.datepicker("setDate", 1)
    },
    addArrowsCalendar: function () {
        this.root;
        setTimeout(function () {
            var a = $(".ui-datepicker-prev"),
                b = $(".ui-datepicker-next");
            a.addClass("icon-ios-arrow-left"), b.addClass("icon-ios-arrow-right")
        }, 200)
    },
    toolTipBookingModule: function () {
        var a = $(".tooltip-cta");
        a.each(function () {
            _this = $(this);
            var a = _this.parents(".booking-panel").find(".tool-tip-container").html();
            _this.tooltip({
                content: a,
                position: {
                    my: "right+25 top",
                    at: "enter bottom+11",
                    using: function (a, b) {
                        $(this).css(a), $(this).addClass(b.vertical)
                    }
                }
            })
        })
    },
    addRemoveRooms: function () {
        $(".room-block").eq(0).find(".delete-room").addClass("hidden"), this.roomCounter = 1, this.maxRooms = $(".room-addition-block").attr("data-max-rooms"), this.addRoomBlock(), this.removeRoomBlock()
    },
    addRoomBlock: function () {
        var a = this,
            b = $(".add-room");
        b.on("click", function (c) {
            if (c.preventDefault(), a.roomCounter < a.maxRooms) {
                a.roomCounter++;
                var d = $(".room-block").first().clone(!0);
                d.find(".room-number").text("Room " + a.roomCounter), d.find(".adults select").attr("name", "adult_Room" + a.roomCounter), d.find(".children select").attr("name", "children_Room" + a.roomCounter), d.find(".delete-room").removeClass("hidden");
                d.find("select"), d.find(".adults select").val(), d.find(".children select").val();
                d.insertBefore(b.parent()), a.selectValueCalc(), a.roomCounter > a.maxRooms - 1 && b.hide()
            }
        })
    },
    removeRoomBlock: function () {
        var a = this,
            b = $(".add-room");
        $(".room-addition-container").on("click", ".delete-room", function () {
            1 != $(".room-block").length && ($(this).parents(".room-block").remove(), a.roomCounter--, a.resetRoomNumber(), a.selectValueCalc(), b.show())
        })
    },
    resetRoomNumber: function () {
        var a = $(".room-block");
        a.each(function (a, b) {
            var c = a + 1;
            $(this).find(".room-number").text("Room " + c), $(this).find(".adults select").attr("name", "adult_Room" + c), $(this).find(".children select").attr("name", "children_Room" + c)
        })
    },
    openCloseSpecialCode: function () {
        var a = $(".special-code-cta");
        a.on("click", function () {
            $(this).hide(), $(this).next().slideDown(function () {
                $(this).find(".enter-code-block input").on("focus", function () {
                    $(this).parents(".field-container").addClass("active")
                })
            })
        }), $(".special-code-block").on("click", ".close-code-cta", function () {
            $(this).parents(".special-code-container").slideUp(function () {
                a.show()
            })
        })
    },
    selectValueCalc: function () {
        var a = $(".drop-panel-block").find("select"),
            b = 0;
        a.each(function () {
            var a, c = $(this).find("option:selected");
            b += Number(c.text()), a = b > 1 ? b + " Guests" : b + " Guest", $(this).parents(".drop-selector").find("span.guests").text(a)
        }), $(".drop-panel-block").each(function () {
            var a, b = $(this).find(".room-block").length;
            a = b > 1 ? b + " Rooms" : b + " Room", $(this).parents(".drop-selector").find("span.rooms").text(a)
        })
    },
    populateGuestDetails: function () {
        var a = this,
            b = $(".guest-details"),
            c = $(".room-addition-container select"),
            d = $(".room-addition-container .confirm-cta"),
            e = $(".booking-panel .button-submit"),
            f = $(".drop-panel-block");
        b.on("click", function (a) {
            var b = $(this).next(),
                c = $(this).find(".field-container");
            a.stopPropagation(), Shangrila.hideElement(), "block" == b.css("display") ? (c.removeClass("icon-ios-arrow-up").addClass("icon-ios-arrow-down"), b.slideUp(300)) : (c.removeClass("icon-ios-arrow-down").addClass("icon-ios-arrow-up"), b.slideDown(250)), callback = function () {
                c.removeClass("icon-ios-arrow-up").addClass("icon-ios-arrow-down"), b.slideUp(), $("input#room-results").val(JSON.stringify($("#bookingPanelForm").serializeObject()))
            }, Shangrila.setEscapeElement(f), Shangrila.setEscapeCallback(callback)
        }), c.each(function () {
            $(this).on("change", function () {
                a.selectValueCalc()
            })
        }), d.on("click", function () {
            return $(this).parents(".room-guests-block").find(".guest-details .field-container").removeClass("icon-ios-arrow-up").addClass("icon-ios-arrow-down"), $(this).parents(".drop-panel-block").slideUp(), $("input#room-results").val(JSON.stringify($("#bookingPanelForm").serializeObject())), !1
        }), e.on("click", function () {
            $("input#room-results").val(JSON.stringify($("#bookingPanelForm").serializeObject()))
        }), $(document).on("keyup", function (a) {
            var b = a.keyCode || a.which;
            27 == b && "block" == $(".drop-panel-block").css("display") && d.trigger("click")
        })
    },
    searchHotelsDropPanel: function () {
        var a = $(".search-hotels-block");
        a.each(function () {
            var a = $(this).find("input[type=text]"),
                b = $(this).find(".drop-search-panel"),
                c = $(this).find(".close-btn"),
                d = b.find("li a"),
                e = a.parent(".ui-textinput");
            a.on("keyup", function (c) {
                var d = a.val().length;
                d > 0 ? (b.slideDown(), b.scrollTop(0), $(this).parent().removeClass("icon-ios-search"), $(this).parent().find(".close-btn").show()) : (b.hide(), $(this).parent().addClass("icon-ios-search"), $(this).parent().find(".close-btn").hide())
            }), $(this).on("click", ".close-btn", function () {
                "" === a.val() ? a.val("") : a.val(), a.val(""), b.scrollTop(0), b.hide(), $(this).parent().addClass("icon-ios-search"), $(this).hide()
            }), d.on("click", function () {
                var a = $(this).text();
                $(this).parents(".search-hotels-block").find('input[name="searchItem"]').val(a), b.slideUp(), c.show(), e.removeClass("icon-ios-search")
            })
        })
    },
    bookingModuleMobile: function () {
        var a = $(".mobile-header .book-now-button"),
            b = $(".booking-panel .booking-close-btn");
        a.on("click", function () {
            $(".booking-panel").removeAttr("style"), Shangrila.lockBodyScroll(), $(".booking-panel").animate({
                left: 0
            })
        }), b.on("click", function () {
            $(".booking-panel").animate({
                left: "100%"
            }), Shangrila.unlockBodyScroll()
        })
    },
    resetBookingModule: function () {
        var a = $(".book-room-cta a"),
            b = $(".form-elements-section");
        Shangrila.screenWidth >= Shangrila.small && (a.removeClass("icon-ios-arrow-up").addClass("icon-ios-arrow-down"), b.removeAttr("style"))
    },
    viewportChange: function () { }
}, Shangrila.modules.push("bookingModule"), $("#img-2-container").length > 0 && candid.wall("#img-2-container", {
    //id: "3e1601cd-d88b-4192-a119-9f9add6493e3",
    id: $("#img-2-container").data("candidguid"),
    layout: "standard;ct-minimal",
    scroll: !1,
    count: 2,
    sort: "Random",
    loadMoreHtml: null,
    ready: function (a) {
        $(this).find(".candid-wall-cell:first-child").addClass("col-xs-12"), $(this).find(".candid-wall-cell:nth-child(n+2)").find(".image-container").addClass("hidden-xs")
    }
}), $("#img-4-container").length > 0 && candid.wall("#img-4-container", {
    id: "3e1601cd-d88b-4192-a119-9f9add6493e3",
    //id: $(".candid-wall-cell").data("candidguid"),
    layout: "standard;ct-minimal",
    scroll: !1,
    count: 4,
    sort: "Random",
    loadMoreHtml: null,
    ready: function (a) {
        $(this).find(".candid-wall-cell:first-child").addClass("col-xs-12"), $(this).find(".candid-wall-cell:nth-child(n+2)").find(".image-container").addClass("hidden-xs")
    }
}), Shangrila.allCarousels = {
    mainCarouselOptions: {
        margin: 0,
        items: 1,
        loop: !0,
        nav: !0,
        navText: !1,
        dots: !1,
        info: !0,
        smartSpeed: 1e3,
        responsive: {
            0: {
                center: !0,
                stagePadding: 20,
                margin: 10
            },
            768: {
                stagePadding: 0
            }
        }
    },
    mobileCarouselOptions: {
        items: 1,
        loop: !0,
        nav: !0,
        navText: !1,
        dots: !1,
        info: !0,
        smartSpeed: 500,
        autoHeight: !1,
        center: !0,
        stagePadding: 20,
        margin: 10
    },
    init: function () {
        this.root = Shangrila, this.initCarousels(), this.adjustHeight(), this.carouselMobile(), this.adjustHeightMobile()
    },
    initCarousels: function () {
        var a = (this.root, this);
        $(".mixed-carousel").each(function () {
            $owlContainer = $(this), $owlSlides = $(this).children(".item");
            var b = $owlSlides.length;
            $owlSlides.length > 1 ? (! function () {
                var a = b > 9 ? b : "0" + b;
                $owlSlides.each(function (b, c) {
                    var d = ($(this), 9 > b ? "0" + (b + 1) : b + 1);
                    $(this).find(".pagination").text(d + " / " + a)
                })
            }(), $owlContainer.owlCarousel(a.mainCarouselOptions)) : $owlContainer.addClass("no-carousel")
        })
    },
    carouselReset: function () {
        this.root;
        Shangrila.screenWidth > Shangrila.extraSmall ? ($(".mobile-carousel").trigger("destroy.owl"), $(".mobile-carousel").show()) : ($(".mobile-carousel").trigger("destroy.owl"), this.carouselMobile(), this.adjustHeightMobile())
    },
    carouselMobile: function () {
        var a = (this.root, this);
        $(".mobile-carousel").each(function () {
            $owlContainer = $(this), $owlSlides = $(this).children(".item");
            var b = $owlSlides.length;
            if ($owlSlides.length > 1 && Shangrila.screenWidth < Shangrila.extraSmall) {
                ! function () {
                    var a = b > 9 ? b : "0" + b;
                    $owlSlides.each(function (b, c) {
                        var d = ($(this), 9 > b ? "0" + (b + 1) : b + 1);
                        $(this).attr("data-pos", d + " / " + a)
                    })
                }(), $owlContainer.owlCarousel(a.mobileCarouselOptions), $owlContainer.find(".owl-nav").append('<span class="pagination"></span>');
                var c = $owlContainer.find(".owl-item.active").find(".item").attr("data-pos");
                $owlContainer.parents(".carousel-container").find(".pagination").text(c), $owlContainer.on("initialized.owl.carousel changed.owl.carousel resized.owl.carousel", function (a) {
                    var b = $(this).find(".item").eq(a.item.index).attr("data-pos");
                    $(this).find(".pagination").text(b)
                })
            } else $owlContainer.show(), $owlContainer.addClass("no-carousel")
        })
    },
    adjustHeight: function () {
        this.root;
        $(".mixed-carousel").length > 0 && (Shangrila.screenWidth < Shangrila.extraSmall ? $(".mosaic-banner-carousel .item .equalHeight").css({
            height: "auto"
        }) : $(".mosaic-banner-carousel .item").each(function () {
            $(this).find(".equalHeight").heightAdjust()
        }))
    },
    adjustHeightMobile: function () {
        if ($(".mobile-carousel").length > 0) {
            var a = $(".mobile-carousel"),
                b = $(".mobile-equal-height-block");
            a.each(function () {
                var a = $(this).find(b);
                Shangrila.screenWidth > 0 && setTimeout(function () {
                    a.heightAdjust()
                }, 200)
            })
        }
    },
    viewportChange: function () {
        this.adjustHeight(), this.adjustHeightMobile(), this.carouselReset()
    }
}, Shangrila.modules.push("allCarousels"), Shangrila.contactDetails = {
    init: function () {
        this.root = Shangrila, this.bindEvents()
    },
    bindEvents: function () {
        this.root;
        this.accordionHandler()
    },
    accordionHandler: function () {
        var a = this.root;
        $(".room-contact-details .accordion-header").on("click", function () {
            var b = $(this),
                c = $(".room-contact-container > li > .description"),
                d = $(".room-contact-container > li .accordion-header"),
                e = b.parent("li"),
                f = e.find(" > .description");
            d.removeClass("icon-accordian-minus");
            var g = function () {
                a.scrollToElement(b), b.addClass("icon-accordian-minus")
            };
            a.screenWidth < a.extraSmall && a.accordionHandler(b, d, f, c, g)
        })
    },
    resetAccordion: function () {
        var a = this.root,
            b = $(".room-contact-container > li > .description"),
            c = $(".room-contact-container > li .accordion-header");
        a.screenWidth < a.extraSmall ? (b.hide(), c.removeClass("icon-accordian-minus")) : (b.show(), c.removeClass("icon-accordian-minus"))
    },
    viewportChange: function () {
        this.resetAccordion()
    }
}, Shangrila.modules.push("contactDetails"), Shangrila.equalHeightSections = {
    init: function () {
        this.root = Shangrila, this.bindEvents()
    },
    bindEvents: function () {
        this.root;
        this.adjustHeight()
    },
    adjustHeight: function () {
        var a = $(".equal-height-section"),
            b = $(".equal-height-block");
        a.each(function () {
            var a = $(this).find(b);
            Shangrila.screenWidth < Shangrila.extraSmall ? a.css({
                height: "auto"
            }) : a.heightAdjust()
        })
    },
    viewportChange: function () {
        this.adjustHeight()
    }
}, Shangrila.modules.push("equalHeightSections"), Shangrila.footer = {
    init: function () {
        this.root = Shangrila, this.bindEvents()
    },
    bindEvents: function () {
        var a = this.root;
        this.accordionHandler(), a.placeholderHandler()
    },
    accordionHandler: function () {
        var a = this.root;
        $(".sitelinks .accordion-header").on("click", function () {
            var b = $(this),
                c = $(".sitelinks > li > ul"),
                d = $(".sitelinks > li .accordion-header"),
                e = b.parent("li"),
                f = e.find(" > ul");
            d.removeClass("icon-accordian-minus");
            var g = function () {
                a.scrollToElement(b), b.addClass("icon-accordian-minus")
            };
            a.screenWidth < a.small && a.accordionHandler(b, d, f, c, g)
        })
    },
    retinaReplacement: function () {
        $(".retina-image").each(function () {
            var a = ($(this).height() / 2, $(this).width() / 2);
            $(this).css("width", a)
        })
    },
    resetAccordion: function () {
        var a = this.root,
            b = $(".sitelinks > li > ul"),
            c = $(".sitelinks > li .accordion-header");
        a.screenWidth < a.small ? (b.hide(), c.removeClass("icon-accordian-minus")) : (b.show(), c.removeClass("icon-accordian-minus"))
    },
    viewportChange: function () {
        this.resetAccordion()
    }
}, Shangrila.modules.push("footer"),
    function (a) {
        if (a("#google-map").length > 0) {
            var b = document.createElement("script");
            b.src = "http://maps.google.com/maps/api/js?key=AIzaSyDYc8lG9BvFuyafz1egTj1h22usLnUp6tI&sensor=false&callback=initialize", document.body.appendChild(b)
        }
    }(jQuery), Shangrila.headerPopup = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.onFindHotelClick(), this.onFindHotelClose(), this.onFindBookingLoginClick(), this.onFindBookingLoginClose(), this.onCurrencyLanguageClick(), this.onCurrencyLanguageClose(), this.deactivateBodyLock()
        },
        deactivateBodyLock: function () {
            Shangrila.screenWidth >= Shangrila.small && Shangrila.unlockBodyScroll()
        },
        onFindHotelClick: function () {
            $('a[data-action="show-hotel-popup"]').on("click", function (a) {
                Shangrila.lockBodyScroll(), Shangrila.screenWidth >= Shangrila.small ? $(".hotel-popup").animate({
                    top: 0
                }) : $(".hotel-popup").animate({
                    left: 0
                })
            })
        },
        onFindHotelClose: function () {
            var a = this;
            $('.hotel-popup a[data-action="hide-hotel-popup"]').on("click", function (b) {
                Shangrila.screenWidth >= Shangrila.small ? $(".hotel-popup").animate({
                    top: "-100%"
                }) : $(".hotel-popup").animate({
                    left: "100%"
                }), a.deactivateBodyLock()
            })
        },
        onFindBookingLoginClick: function () {
            $('a[data-action="show-login-booking-popup"]').on("click", function (a) {
                var b = $(this),
                    c = parseInt(b.attr("data-tab-index"));
                Shangrila.lockBodyScroll(), Shangrila.header.activateTab(c), Shangrila.screenWidth >= Shangrila.small ? $(".login-booking-popup").animate({
                    top: 0
                }) : $(".login-booking-popup").animate({
                    left: 0
                })
            })
        },
        onFindBookingLoginClose: function () {
            var a = this;
            $('.login-booking-popup a[data-action="hide-login-booking-popup"]').on("click", function (b) {
                Shangrila.screenWidth >= Shangrila.small ? $(".login-booking-popup").animate({
                    top: "-100%"
                }) : $(".login-booking-popup").animate({
                    left: "100%"
                }), a.deactivateBodyLock()
            })
        },
        onCurrencyLanguageClick: function () {
            $('a[data-action="show-currency-language-popup"]').on("click", function (a) {
                var b = $(this),
                    c = parseInt(b.attr("data-tab-index"));
                Shangrila.lockBodyScroll(), Shangrila.header.activateTab(c), Shangrila.screenWidth >= Shangrila.small ? $(".currency-language-popup").animate({
                    top: 0
                }) : $(".currency-language-popup").animate({
                    left: 0
                })
            })
        },
        onCurrencyLanguageClose: function () {
            var a = this;
            $('.currency-language-popup a[data-action="hide-currency-language-popup"]').on("click", function (b) {
                Shangrila.screenWidth >= Shangrila.small ? $(".currency-language-popup").animate({
                    top: "-100%"
                }) : $(".currency-language-popup").animate({
                    left: "100%"
                }), a.deactivateBodyLock()
            })
        }
    }, Shangrila.modules.push("headerPopup"), Shangrila.header = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.resetElements(), this.onBurgerClick(), this.onCloseClick(), this.onPrimaryNavClick(), this.onBacklinkClick(), this.activateTab(), this.activateTab(), this.hideFlyout(), this.onBookNowClick(), this.changeMenuLevel(), this.onLocalMoreClick()
        },
        onLocalMoreClick: function () {
            $('.local-navigation a[data-action="show-local-flyout"]').on("click", function (a) {
                a.preventDefault();
                var b = $(this);
                flyoutWrapper = b.parent().find(".flyout-wrapper"), Shangrila.screenWidth >= Shangrila.small ? "block" != flyoutWrapper.css("display") ? (flyoutWrapper.hide().slideDown(), b.find("> span").removeClass().addClass("icon-ios-arrow-up")) : (flyoutWrapper.slideUp(), b.find("> span").removeClass().addClass("icon-ios-arrow-down")) : flyoutWrapper.animate({
                    left: 0
                }), a.stopPropagation()
            })
        },
        changeMenuLevel: function () {
            $('*[data-type="more-menu"]').each(function (a, b) {
                var c = $(this).clone(!0, !0),
                    d = $(this).parents('*[data-link-type="more-menu"]').parent().parent();
                d.find("> .more-links-mobile").append(c)
            })
        },
        onBookNowClick: function () {
            $(".book-now-desktop").on("click", function (a) {
                if (a.preventDefault(), $(".main-banner-hotel-landing").length > 0 && Shangrila.screenWidth >= Shangrila.small) {
                    var b = $("#overview").offset().top - $(".header-container").outerHeight();
                    Shangrila.scrollToPosition(b)
                } else Shangrila.scrollToPosition($(".booking-panel").offset().top - $(".header-container").outerHeight() + 10)
            })
        },
        hideFlyout: function () {
            $(window).on("scroll", function (a) {
                Shangrila.screenWidth >= Shangrila.small && ($('.flyout-wrapper:not(".local-navigation")').slideUp(), $('.menulink-wrapper li a[data-action="show-flyout"]').removeClass("active").find("> span").removeClass().addClass("icon-ios-arrow-down"))
            })
        },
        onBurgerClick: function () {
            $(".hamburger-menu").on("click", function (a) {
                a.preventDefault(), $(".mobile-header").fadeOut(), $(".header-container").addClass("active").animate({
                    height: "100%",
                    bottom: "0"
                }, 400, function () {
                    $(".utility-links-wrapper, .utility-links-right.currency-language , .primary-navigation").animate({
                        left: 0
                    })
                }), Shangrila.lockBodyScroll()
            })
        },
        onCloseClick: function () {
            $(".utility-links-wrapper > .icon-close").on("click", function (a) {
                a.preventDefault(), $(".utility-links-wrapper, .utility-links-right.currency-language , .primary-navigation").animate({
                    left: "100%"
                }, 400, function () {
                    $(".header-container").removeClass("active").animate({
                        height: $(".mobile-header").outerHeight(),
                        bottom: 0
                    }, 400, function () {
                        $(".mobile-header").fadeIn()
                    })
                }), Shangrila.unlockBodyScroll()
            })
        },
        onPrimaryNavClick: function () {
            $('.primary-navigation ul.menulink-wrapper > li a[data-action="show-flyout"]').on("click", function (a) {
                a.preventDefault();
                var b = $(this),
                    c = b.parents(".primary-navigation"),
                    d = c.find("ul li > a"),
                    e = c.find('.flyout-wrapper:not(".local-navigation")'),
                    f = b.parent().find("> .flyout-wrapper");
                Shangrila.screenWidth >= Shangrila.small ? b.hasClass("active") ? (f.slideUp(), b.removeClass("active"), b.find("span").removeClass().addClass("icon-ios-arrow-down")) : e.not(f).slideUp(400, function () {
                    d.removeClass("active"), f.hasClass("local-navigation") ? f.hide().slideDown() : f.hide().css({
                        maxHeight: Shangrila.screenHeight - $(".header-container").outerHeight(),
                        "overflow-y": "auto"
                    }).slideDown(), d.find("span").removeClass().addClass("icon-ios-arrow-down"), b.addClass("active"), b.find("span").removeClass().addClass("icon-ios-arrow-up")
                }) : ($(".utility-links-wrapper, .utility-links-right.currency-language , .primary-navigation").animate({
                    left: "-100%"
                }), $(".primary-navigation").css("overflow", "visible"), f.animate({
                    left: 0
                })), a.stopPropagation()
            })
        },
        onBacklinkClick: function () {
            $('.flyout-title > a[data-action="hide-flyout"]').on("click", function (a) {
                a.preventDefault();
                var b = $(this),
                    c = b.parents(".flyout-wrapper");
                $(".utility-links-wrapper, .utility-links-right.currency-language , .primary-navigation").animate({
                    left: 0
                }), $(".primary-navigation").css("overflow", "auto"), c.animate({
                    left: "100%"
                })
            })
        },
        activateTab: function (a) {
            if (a || (a = 0), Shangrila.screenWidth < Shangrila.small) $(".nav-login-language").find(".tabs-wrapper").each(function (b, c) {
                Shangrila.tabWidget.showCustomTab($(this), a)
            });
            else {
                var b = $(".nav-login-language").find(".tabs-wrapper"),
                    c = b.next(".tabs-content-wrapper").find(".tabs-content");
                b.find("a.tab").removeClass("active"), c.show()
            }
        },
        resetElements: function () {
            $(".header-container, .mobile-header, .utility-links-wrapper, .primary-navigation").removeAttr("style"), $(".header-container").removeClass("active"), $(".header-container").find("*").removeAttr("style"), $('.primary-navigation ul li a[data-action="show-flyout"]').removeClass("active"), Shangrila.screenWidth >= Shangrila.small ? $('.menulink-wrapper > li > a > span, .flyout-wrapper.local-navigation a[data-action^="*"] > span').removeClass().addClass("icon-ios-arrow-down") : $('.menulink-wrapper > li > a > span, .flyout-wrapper.local-navigation a[data-action^="*"] > span').removeClass().addClass("icon-ios-arrow-right")
        },
        viewportChange: function () {
            this.resetElements(), this.activateTab(), Shangrila.unlockBodyScroll()
        }
    }, Shangrila.modules.push("header"), Shangrila.hotelSupplies = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.root;
            this.accordionHandler()
        },
        accordionHandler: function () {
            var a = this.root;
            $(".everything-links .accordion-header").on("click", function () {
                var b = $(this),
                    c = $(".everything-links > li > ul"),
                    d = $(".everything-links > li .accordion-header"),
                    e = b.parent("li"),
                    f = e.find(" > ul");
                d.removeClass("icon-accordian-minus");
                var g = function () {
                    a.scrollToElement(b), b.addClass("icon-accordian-minus")
                };
                a.screenWidth < a.small && a.accordionHandler(b, d, f, c, g)
            })
        },
        resetAccordion: function () {
            var a = this.root,
                b = $(".everything-links > li > ul"),
                c = $(".everything-links > li .accordion-header");
            a.screenWidth < a.small ? (b.hide(), c.removeClass("icon-accordian-minus")) : (b.show(), c.removeClass("icon-accordian-minus"))
        },
        viewportChange: function () {
            this.resetAccordion()
        }
    }, Shangrila.modules.push("hotelSupplies"), Shangrila.inPageNavigation = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.offSetCalc(), this.thePageNavigation(), this.mobileInpageNavigation(), this.scrollLinkFollow(), this.exploreClick(), this.sharePage()
        },
        offSetCalc: function () {
            var a = (this.root, $(".main-banner-hotel-landing"), $(".booking-panel")),
                b = $(".in-page-navigation"),
                c = $(".inpage-element"),
                d = $("header");
            c.each(function () {
                $(this).attr("data-pos", parseInt($(this).offset().top))
            }), d.attr("data-height", parseInt(d.outerHeight())), a.length && (a.attr("data-height", parseInt(a.outerHeight())), a.attr("data-pos", parseInt(a.offset().top))), Shangrila.screenWidth > Shangrila.small ? b.attr("data-height", 38) : b.attr("data-height", 47)
        },
        scrollLinkFollow: function () {
            if ($(".in-page-navigation").length > 0 && $(".booking-panel").length > 0) {
                var a, b = $(".main-banner-hotel-landing"),
                    c = $(".booking-panel"),
                    d = $(".in-page-navigation"),
                    e = (d.find('a[href^="#"]'), $(".explore-button"), $("header")),
                    f = (b.outerHeight(), $(".inpage-element"));
                Shangrila.screenWidth < Shangrila.small ? (a = parseInt(parseInt(e.attr("data-height")) + parseInt(d.attr("data-height"))), offsetBottomVal = a - 50) : (a = parseInt(parseInt(c.attr("data-height")) + parseInt(d.attr("data-height"))), offsetBottomVal = a - 100), f.each(function () {
                    var b = $(this);
                    b.attr("data-height", b.outerHeight()), $(this).waypoint(function (a) {
                        if ("up" === a) {
                            var c = b,
                                d = c.attr("id");
                            if ($(".horizontal-scroll li").removeClass("active"), $(".horizontal-scroll li a[href='#" + d + "']").parent().addClass("active"), Shangrila.screenWidth < Shangrila.small) {
                                var e = $(".horizontal-scroll li a[href='#" + d + "']").parent().addClass("active").text();
                                $(".selected-item span").text(e), $(".horizontal-scroll li").removeClass("hidden"), $(".horizontal-scroll li a[href='#" + d + "']").parent().addClass("hidden")
                            }
                        }
                    }, {
                        offset: offsetBottomVal
                    }), $(this).waypoint(function (a) {
                        if ("down" === a) {
                            var c = b,
                                d = c.attr("id");
                            if ($(".horizontal-scroll li").removeClass("active"), $(".horizontal-scroll li a[href='#" + d + "']").parent().addClass("active"), Shangrila.screenWidth < Shangrila.small) {
                                var e = $(".horizontal-scroll li a[href='#" + d + "']").parent().addClass("active").text();
                                $(".selected-item span").text(e), $(".horizontal-scroll li").removeClass("hidden"), $(".horizontal-scroll li a[href='#" + d + "']").parent().addClass("hidden")
                            }
                        }
                    }, {
                        offset: a
                    })
                })
            }
        },
        thePageNavigation: function () {
            this.root;
            if ($(".in-page-navigation").length > 0 && $(".booking-panel").length > 0) {
                var a = $(".main-banner-hotel-landing"),
                    b = $(".booking-panel"),
                    c = $(".in-page-navigation"),
                    d = c.find('a[href^="#"]'),
                    e = ($(".explore-button"), $("header"));
                a.outerHeight(), $(".inpage-element"), parseInt(e.attr("data-height"));
                d.on("click", function (a) {
                    a.preventDefault();
                    var d = $(this).parent().index();
                    c.find("li").removeClass("active"), $(this).parent().addClass("active"), $(".inpage-element").each(function () {
                        $(this).attr("data-pos", parseInt($(this).offset().top))
                    });
                    var f = parseInt($(".inpage-element").eq(d).attr("data-pos"));
                    b.addClass("sticked");
                    var g;
                    Shangrila.screenWidth > Shangrila.small ? (g = parseInt(parseInt(b.attr("data-height")) + parseInt(c.attr("data-height")) - 10), c.addClass("sticked").css({
                        top: b.attr("data-height") + "px"
                    })) : (g = parseInt(parseInt(e.attr("data-height")) + parseInt(c.attr("data-height")) - 10), c.addClass("sticked").css({
                        top: e.attr("data-height") + "px"
                    })), setTimeout(function () {
                        $("html, body").stop().animate({
                            scrollTop: parseInt(f - g)
                        }, 500)
                    }, 200)
                })
            }
        },
        mobileInpageNavigation: function () {
            this.root;
            if ($(".in-page-navigation").length > 0) {
                var a = ($(".in-page-navigation"), $(".in-page-navigation .horizontal-scroll li a")),
                    b = $(".selected-item");
                b.on("click", function () {
                    var a = $(this).next();
                    "block" == a.css("display") ? (b.find("span").removeClass("icon-ios-arrow-up"), a.slideUp()) : (b.find("span").addClass("icon-ios-arrow-up"), a.slideDown())
                }), a.on("click", function (c) {
                    var d = $(this),
                        e = d.text(),
                        f = d.parents(".in-page-navigation").find(".selected-item span"),
                        g = d.parents(".in-page-navigation").find(".horizontal-scroll"),
                        h = function () {
                            f.text(e), a.parent().removeClass("hidden"), d.parent().addClass("hidden"), b.find("span").removeClass("icon-ios-arrow-up")
                        };
                    Shangrila.screenWidth < Shangrila.small ? (g.hide(), h()) : g.show()
                })
            }
        },
        bookingModuleSticked: function () {
            this.root;
            if (0 === $(".in-page-navigation").length && $(".booking-panel").length > 0) {
                var a = $("#booking-module"),
                    b = (parseInt(a.attr("data-pos")), parseInt($("header").attr("data-pos")), parseInt(a.attr("data-height")));
                a.waypoint(function (c) {
                    "down" === c && ($(".header-container").addClass("fixed-to-relative"), a.css({
                        top: -b
                    }).addClass("sticked").animate({
                        top: 0
                    }))
                }, {
                    triggerOnce: !0,
                    offset: -b
                }), a.waypoint(function (b) {
                    "up" === b && (a.removeClass("sticked").removeAttr("style"), $(".header-container").removeClass("fixed-to-relative"));
                }, {
                    triggerOnce: !0,
                    offset: 0
                })
            }
        },
        resetInlineNavigation: function () {
            Shangrila.screenWidth < Shangrila.small ? ($(".selected-item").show(), $(".in-page-navigation").find(".horizontal-scroll").hide()) : ($(".selected-item").hide(), $(".in-page-navigation").find(".horizontal-scroll").show(), $(".in-page-navigation li").removeClass("hidden"))
        },
        exploreClick: function () {
            $(".explore-button").length > 0 && $(".explore-button").on("click", function (a) {
                a.preventDefault();
                var b = $(this).attr("href"),
                    c = $(b);
                Shangrila.scrollToElement(c)
            })
        },
        viewportChange: function () {
            this.offSetCalc(), this.resetInlineNavigation(), this.scrollLinkFollow()
        },
        sharePage: function () {
            var a = $(".share-link a.share-icon"),
                b = $(".share-link a.share-icon span"),
                c = ($(".share-link"), $(".share-icon-container"));
            a.on("click", function (a) {
                var d = c.is(":hidden");
                d ? (b.hide(), $(this).removeClass("share-icon"), $(this).addClass("icon-close shadow-box"), c.show()) : (b.show(), $(this).addClass("share-icon"), $(this).removeClass("icon-close shadow-box"), c.hide())
            })
        }
    }, Shangrila.modules.push("inPageNavigation"), Shangrila.locationequalHeightSections = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.root;
            this.adjustHeight()
        },
        adjustHeight: function () {
            var a = $(".map-equal-height-section"),
                b = $(".map-equal-height-block");
            a.each(function () {
                var a = $(this).find(b);
                if (Shangrila.screenWidth < Shangrila.small) a.css({
                    height: "auto"
                }), $(this).css({
                    height: "auto"
                });
                else {
                    a.heightAdjust();
                    var c = b.height();
                    $(this).css("height", c)
                }
            })
        },
        viewportChange: function () {
            this.adjustHeight()
        }
    }, Shangrila.modules.push("locationequalHeightSections"), Shangrila.moduleAnimation = {
        init: function () {
            this.bindEvents()
        },
        bindEvents: function () {
            Shangrila.screenWidth >= Shangrila.extraSmall && (this.getModules(), $(".explore-button").length > 0 && this.animateArrow())
        },
        getModules: function () {
            var a = this;
            $.ajax({
                url: "/Content/js/module-animation.json",
                type: "GET",
                dataType: "json"
            }).done(function (b) {
                for (var c = b, d = 0; d < c.length; d++) {
                    var e = $(c[d].element);
                    e.animation = c[d].animation, e.delay = c[d].delay ? c[d].delay : 0, a.setWaypoint(e)
                }
            }).fail(function () { })
        },
        setWaypoint: function (a) {
            a.each(function (b, c) {
                var d = $(this);
                d.data("animation", a.animation), d.data("delay", a.delay), d.css("opacity", "0"), d.waypoint(function (a) {
                    "down" != a || $(this.element).data("animated") || (0 === d.data("delay") ? $(this.element).animateCss(d.data("animation")) : $(this.element).css("animation-delay", d.index() * d.data("delay") + "s").animateCss(d.data("animation")), $(this.element).data("animated", !0)), d.css("opacity", "1"), this.destroy()
                }, {
                    offset: "95%"
                })
            })
        },
        animateArrow: function () {
            $(".explore-button").css("animation-iteration-count", "infinite").animateCss("pulse")
        }
    }, Shangrila.modules.push("moduleAnimation"), Shangrila.navhotelOverlay = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.accordionHandler()
        },
        accordionHandler: function () {
            var a = this.root;
            $(".nav-hotel-overlay .accordion-header").on("click", function () {
                var b = $(this),
                    c = b.parents(".nav-hotel-overlay"),
                    d = b.attr("data-anchor"),
                    e = c.find("ul[data-ref]"),
                    f = c.find(".accordion-header[data-anchor]"),
                    g = e.filter("[data-ref='" + d + "']"),
                    h = function () {
                        var a = $(".nav-hotel-wrapper").scrollTop(),
                            c = b.offset().top,
                            d = $(".nav-hotel-overlay .close").outerHeight(!0),
                            e = a + c - d;
                        $(".nav-hotel-wrapper").animate({
                            scrollTop: e
                        })
                    };
                a.screenWidth < a.small && a.accordionHandler(b, f, g, e, h)
            })
        },
        resetAccordion: function () {
            var a = this.root,
                b = $(".nav-hotel-overlay"),
                c = b.find("ul[data-ref]"),
                d = b.find(".accordion-header[data-anchor]");
            a.screenWidth < a.small ? c.hide() : (c.show(), d.removeClass("active"))
        },
        viewportChange: function () {
            this.resetAccordion()
        }
    }, Shangrila.modules.push("navhotelOverlay"), Shangrila.navflyoutAccordian = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.root;
            this.accordionHandler()
        },
        accordionHandler: function () {
            var a = this.root;
            $(".flyout-container .accordion-header").on("click", function () {
                var b = $(this),
                    c = $(".flyout-container .nav-type-block > .sub-links"),
                    d = $(".flyout-container .nav-type-block .accordion-header"),
                    e = b.parent(".nav-type-block"),
                    f = e.find(" > .sub-links");
                d.removeClass("icon-accordian-minus");
                var g = function () {
                    a.scrollToElement(b), b.addClass("icon-accordian-minus")
                };
                a.screenWidth < a.small && a.accordionHandler(b, d, f, c, g)
            })
        },
        resetAccordion: function () {
            var a = this.root,
                b = $(".flyout-container .nav-type-block > .sub-links"),
                c = $(".flyout-container .nav-type-block .accordion-header");
            a.screenWidth < a.small ? (b.hide(), c.removeClass("icon-accordian-minus")) : (b.show(), c.removeClass("icon-accordian-minus"))
        },
        viewportChange: function () {
            this.resetAccordion()
        }
    }, Shangrila.modules.push("navflyoutAccordian"), Shangrila.priceviewController = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.root;
            this.viewModuleController(), this.resetCarouselonListView()
        },
        viewModuleController: function () {
            $(".price-view-controller").length > 0 && ($(".list-view-cta").on("click", function (a) {
                a.preventDefault(), $(".grid-view-cta").removeClass("active"), $(this).addClass("active"), $(".price-view-controller").addClass("room-landing-list-view-price-container"), $(".price-view-controller").find(".mobile-carousel").trigger("destroy.owl"), $(".room-landing-list-view-price-container").find(".mobile-equal-height-block").removeAttr("style"), $(".price-view-controller").find(".mobile-carousel").show()
            }), $(".grid-view-cta").on("click", function (a) {
                a.preventDefault(), $(".list-view-cta").removeClass("active"), $(this).addClass("active"), $(".price-view-controller").removeClass("room-landing-list-view-price-container"), Shangrila.screenWidth < Shangrila.extraSmall && ($(".price-view-controller").find(".read-more-droplink").css({
                    display: "inline-block"
                }), Shangrila.allCarousels.carouselReset())
            }))
        },
        resetCarouselonListView: function () {
            $(".price-view-controller").hasClass("room-landing-list-view-price-container") && ($(".room-landing-list-view-price-container").find(".mobile-carousel").trigger("destroy.owl"), $(".room-landing-list-view-price-container").find(".mobile-equal-height-block").removeAttr("style"))
        },
        viewportChange: function () {
            this.resetCarouselonListView()
        }
    }, Shangrila.modules.push("priceviewController"), Shangrila.readMoreSection = {
        init: function () {
            this.root = Shangrila, this.readMoreSectionReset(), this.readMoreSection(), this.readMoreLinkSection()
        },
        readMoreSectionReset: function () {
            var a = (this.root, $(".read-more-section-header"));
            a.each(function () {
                $(this).find(".description").removeAttr("style").find(".moreellipses").remove(), $(this).find(".description").find(".morecontent span").unwrap(), $(this).find(".read-more-droplink").removeClass("icon-ios-arrow-up").addClass("icon-ios-arrow-down").text("Read More")
            })
        },
        readMoreSection: function () {
            var a = (this.root, this),
                b = 66,
                c = 45,
                d = "...",
                e = $(".read-more-section-header");
            e.each(function () {
                var e = $(this).find(".read-more-droplink");
                if (Shangrila.screenWidth > 767) a.readMoreSectionReset(), $(this).find(".read-more-droplink").hide();
                else if ($(this).find(".description").length > 0) {
                    var f = $(this).find(".description").html();
                    if (f.length > b) {
                        var g = f.substr(0, b),
                            h = f.substr(b, f.length - b),
                            i = g + '<span class="moreellipses">' + d + '&nbsp;</span><span class="morecontent"><span>' + h + "</span></span>";
                        $(this).find(".description").html(i), $(this).find(".description").css("height", c), e.show()
                    } else e.hide()
                }
            })
        },
        readMoreLinkSection: function () {
            var a = $(".read-more-section-header"),
                b = "Read More",
                c = "Read Less";
            a.each(function () {
                var a = $(this).find(".read-more-droplink"),
                    d = 45;
                $(this).find(".description").html();
                a.on("click", function () {
                    if ($(this).hasClass("icon-ios-arrow-down")) {
                        $(this).removeClass("icon-ios-arrow-down").addClass("icon-ios-arrow-up"), $(this).parents(".read-more-section-header").find(".moreellipses").hide(), $(this).parents(".read-more-section-header").find(".morecontent").slideDown();
                        var a = $(this).parents(".read-more-section-header").find(".morecontent").height();
                        $(this).parents(".read-more-section-header").find(".description").animate({
                            height: a + d - 20
                        }), $(this).text(c)
                    } else $(this).removeClass("icon-ios-arrow-up").addClass("icon-ios-arrow-down"), $(this).parents(".read-more-section-header").find(".moreellipses").show(), $(this).parents(".read-more-section-header").find(".morecontent").stop().hide(), $(this).text(b), $(this).parents(".read-more-section-header").find(".description").animate({
                        height: d
                    })
                })
            })
        },
        viewportChange: function () {
            this.readMoreSectionReset(), this.readMoreSection()
        }
    }, Shangrila.modules.push("readMoreSection"), Shangrila.selectBoxit = {
        init: function () { },
        initializeSelectBox: function (a) {
            if (a) $(a).selectBoxIt().data("selectBoxIt");
            else {
                $("select").selectBoxIt().data("selectBoxIt")
            }
        },
        viewportChange: function () {
            this.setSelectWidth()
        },
        setSelectWidth: function () {
            $(".ui-select-wrapper").each(function (a) {
                var b = $(this),
                    c = b.width(),
                    d = b.find(".selectboxit-container .selectboxit"),
                    e = b.find(".selectboxit-options"),
                    f = parseInt(e.css("paddingLeft")),
                    g = parseInt(e.css("paddingRight")),
                    h = c - f - g;
                e.width(h), e.css("min-width", h), d.width(c), d.css("min-width", c), b.find(".selectboxit.btn").addClass("icon-ios-arrow-down")
            })
        }
    }, Shangrila.modules.push("selectBoxit"), Shangrila.stickyModules = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.stickModules()
        },
        stickModules: function () {
            var a, b, c, d, e, f = $(".booking-panel"),
                g = $(".in-page-navigation"),
                h = $(".header-container");
            $(".main-banner-hotel-landing").length > 0 ? ($("#overview").data("waypoint") && $("#overview").data("waypoint")[0].destroy(), $(window).width() >= Shangrila.small ? (a = f.outerHeight(), b = g.outerHeight(), c = h.outerHeight(), d = a + b - 10, f.css("visibility", "hidden").addClass("sticked").css("top", -a), g.css("visibility", "hidden").addClass("sticked").css("top", -b), $("#overview").data("waypoint") && $("#overview").data("waypoint")[0].destroy(), e = $("#overview").waypoint(function (d) {
                "down" == d ? (f.css("visibility", "visible"), f.stop().animate({
                    top: 0
                }), g.css("visibility", "visible"), g.stop().animate({
                    top: a
                }, function () {
                    h.stop().animate({
                        top: -c
                    })
                })) : (f.stop().animate({
                    top: -a
                }, function () {
                    f.css("visibility", "hidden")
                }), g.stop().animate({
                    top: -b
                }), h.stop().animate({
                    top: 0
                }))
            }, {
                offset: d
            }), $("#overview").data("waypoint", e)) : (a = f.outerHeight(), b = g.outerHeight(), c = h.outerHeight(), d = c + b - 10, g.addClass("sticked").css("top", -b).css("visibility", "visible"), $("#overview").data("waypoint") && $("#overview").data("waypoint")[0].destroy(), e = $("#overview").waypoint(function (a) {
                "down" == a ? g.stop().animate({
                    top: c
                }) : g.stop().animate({
                    top: -b
                })
            }, {
                offset: d
            }), $("#overview").data("waypoint", e))) : $(window).width() >= Shangrila.small ? (a = f.outerHeight(), b = g.outerHeight(), c = h.outerHeight(), d = c, f.data("waypoint") && f.data("waypoint")[0].destroy(), f.css("z-index", 21), e = f.waypoint(function (a) {
                "down" == a ? (f.css("top", d).addClass("sticked"), f.stop().animate({
                    top: 0
                }, function () {
                    h.css("visibility", "hidden")
                })) : (f.removeAttr("style").removeClass("sticked"), h.css("visibility", "visible"))
            }, {
                offset: d
            }), f.data("waypoint", e)) : (f.data("waypoint") && f.data("waypoint")[0].destroy(), f.removeAttr("style").removeClass("sticked"), g.removeAttr("style"), h.removeAttr("style"), h.css("top", 0))
        },
        viewportChange: function () {
            $("#overview").data("waypoint") && $("#overview").data("waypoint")[0].destroy(), $(".booking-panel").data("waypoint") && $(".booking-panel").data("waypoint")[0].destroy();
            $(".header-container").removeAttr("style").removeClass("sticked"), $(".booking-panel").removeAttr("style").removeClass("sticked"), $(".in-page-navigation").removeAttr("style").removeClass("sticked"), this.stickModules()
        }
    }, Shangrila.modules.push("stickyModules"), Shangrila.tabWidget = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.onTabClick()
        },
        showDefaultTab: function () {
            var a = $(".tabs-wrapper"),
                b = this;
            a.each(function (a, c) {
                b.showCustomTab($(this), 0)
            })
        },
        showCustomTab: function (a, b) {
            var c = a.find("a.tab"),
                d = a.next(".tabs-content-wrapper"),
                e = d.find(".tabs-content");
            c.removeClass("active"), c.eq(b).addClass("active"), e.hide(), e.eq(b).show()
        },
        onTabClick: function () {
            var a = $(".tabs-wrapper"),
                b = a.find("a.tab"),
                c = a.next(".tabs-content-wrapper");
            c.find(".tabs-content");
            b.on("click", function (a) {
                a.preventDefault();
                var b = $(this),
                    c = b.parents(".tabs-wrapper"),
                    d = c.find("a.tab"),
                    e = c.next(".tabs-content-wrapper"),
                    f = e.find(".tabs-content");
                b.hasClass("active") || (d.removeClass("active"), f.hide(), b.addClass("active"), f.eq(b.index()).show())
            })
        }
    }, Shangrila.modules.push("tabWidget"), Shangrila.textLimit = {
        init: function () {
            this.root = Shangrila, this.restrictText()
        },
        restrictText: function () {
            var a = $(".restrict").text();
            a.length > 85 && $(".restrict").text(a.substring(0, 85) + "...")
        }
    }, Shangrila.modules.push("textLimit"), Shangrila.fullVideo = {
        init: function () {
            this.root = Shangrila, this.videoBackground()
        },
        videoBackground: function () {
            function a() {
                b.classList.add("stopfade")
            }
            var b = document.getElementById("bgvid");
            b && b.addEventListener("ended", function () {
                b.pause(), a()
            })
        }
    }, Shangrila.videoModules = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.videoLinker()
        },
        videoLinker: function () {
            var a = this.root,
                b = $(".video-link");
            b.each(function () {
                _this = $(this), _this.on("click", function (b) {
                    b.preventDefault();
                    var c = $(this).attr("href");
                    $(".common-popup-block").show();
                    var d = '<div class="pop-up-videoblock"><div class="video-block"><iframe style="width: 100%; height: 100%; position: absolute; top: 0px; bottom: 0px; right: 0px; left: 0px;" src="' + c + '&autoplay" allowfullscreen webkitallowfullscreen mozallowfullscreen><iframe></div></div>';
                    $(".common-popup-block").append(d), a.scrollToTop(), Shangrila.overlayShow()
                })
            }), $(document).on("keyup", function (a) {
                var b = a.keyCode || a.which;
                27 == b && "block" == $(".common-popup-block").css("display") && $(".common-popup-block .close-btn").trigger("click")
            })
        },
        viewportChange: function () {
            "block" == $(".common-popup-block").css("display") && Shangrila.overlayShow()
        }
    }, Shangrila.modules.push("videoModules"), Shangrila.viewController = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.root;
            this.viewModuleController(), this.resetCarouselonListView()
        },
        viewModuleController: function () {
            $(".view-controller").length > 0 && ($(".list-view-cta").on("click", function (a) {
                a.preventDefault(), $(".grid-view-cta").removeClass("active"), $(this).addClass("active"), $(".view-controller").addClass("room-landing-list-view-container"), $(".view-controller").find(".mobile-carousel").trigger("destroy.owl"), $(".room-landing-list-view-container").find(".mobile-equal-height-block").removeAttr("style"), $(".view-controller").find(".mobile-carousel").show()
            }), $(".grid-view-cta").on("click", function (a) {
                a.preventDefault(), $(".list-view-cta").removeClass("active"), $(this).addClass("active"), $(".view-controller").removeClass("room-landing-list-view-container"), Shangrila.screenWidth < Shangrila.extraSmall && ($(".view-controller").find(".read-more-droplink").css({
                    display: "inline-block"
                }), Shangrila.allCarousels.carouselReset())
            }))
        },
        resetCarouselonListView: function () {
            $(".view-controller").hasClass("room-landing-list-view-container") && ($(".room-landing-list-view-container").find(".mobile-carousel").trigger("destroy.owl"), $(".room-landing-list-view-container").find(".mobile-equal-height-block").removeAttr("style"))
        },
        viewportChange: function () {
            this.resetCarouselonListView()
        }
    }, Shangrila.modules.push("viewController"), Shangrila.weatherMaps = {
        init: function () {
            this.root = Shangrila, this.bindEvents()
        },
        bindEvents: function () {
            this.weatherMapsModule()
        },
        weatherMapsModule: function (a) {
            $(".climate-time-control").length > 0 && $(".climate-time-control").each(function (a, b) {
                var c = $(this),
                    d = $(this).attr("data-lat"),
                    e = $(this).attr("data-lon"),
                    h = $(this).attr("data-hotelCode"),
                    f = $(this).attr("data-lang") ? $(this).attr("data-lang") : "en",
                    //g = "http://api.openweathermap.org/data/2.5/weather?lat=" + d + "&lon=" + e + "&lang=" + f + "&units=metric&id=524901&APPID=a58496cdeb8355f9f656ddef42d22069";
                    //g = "/services/weatherservice.svc/GetCurrentWeatherJSON/?lat=" + d + "&lon=" + e + "&lang=" + f;
                    g = "/services/weatherservice.svc/GetCurrentWeatherJSON/?hotelCode=" + h + "&lang=" + f;
                $.getJSON(g, function (a) {
                    var b, d = new Date,
                        e = a.main.temp.toString().split(".")[0],
                        f = a.weather[0].icon,
                        g = a.weather[0].description,
                        h = "/Content/img/icons/",
                        i = ".png",
                        j = parseInt(d.getFullYear()),
                        k = parseInt(d.getMonth()) + 1,
                        l = parseInt(d.getDate()),
                        m = Date.UTC(j, k, l),
                        n = m.toString().slice(0, 10),
                        //o = "https://maps.googleapis.com/maps/api/timezone/json?location=" + a.coord.lat + "," + a.coord.lon + "&timestamp=" + n,
                        o = "/services/weatherservice.svc/GetTimeZoneJSON/?lat=" + a.coord.lat + "&lon=" + a.coord.lon + "&timestamp=" + n,
                        p = c.parents(".main-banner-hotel-landing");
                    b = p.length > 0 ? Shangrila.screenWidth < Shangrila.small ? f + "-gold" : p.hasClass("darker-text") ? f + "-dark" : f : f + "-dark", c.find(".cloud").empty().append('<img src="' + h + b + i + '" alt="' + g + '">'), c.find(".temp").text(e + "°"), $.getJSON(o, function (a) {
                        var b = a.timeZoneId;
                        moment("2016-07-18T12:00:00Z");
                        c.find(".time").text(moment.tz(b).format("h:mm a"))
                    })
                })
            })
        },
        viewportChange: function () {
            this.weatherMapsModule()
        }
    }, Shangrila.modules.push("weatherMaps");