(function ($) {
    var oldFnTab = $.fn.tab;
    $.fn.tab = function (options) {
        options = $.extend({
            defaultIndex: 0,
            activeClass: 'weui_bar_item_on',
            onToggle: $.noop
        }, options);
        const $tabbarItems = this.children().children('.weui_tabbar_item, .weui_navbar_item');
        const $tabBdItems = this.children().children('.weui_tab_bd_item');
        this.toggle = function (index) {
            const $defaultTabbarItem = $tabbarItems.eq(index);
            if ($defaultTabbarItem.hasClass(options.activeClass))
            {
                return;
            }
            $defaultTabbarItem.addClass(options.activeClass).siblings().removeClass(options.activeClass);
            const $defaultTabBdItem = $tabBdItems.eq(index);
            $defaultTabBdItem.show().siblings().hide();
            options.onToggle(index);
        };
        const self = this;
        this.children().children('.weui_tabbar_item, .weui_navbar_item').on('click', function (e) {
            const index = $(this).index();
            self.toggle(index);
        });
        this.toggle(options.defaultIndex);
        return this;
    };
    $.fn.tab.noConflict = function () {
        return oldFnTab;
    };
})($);