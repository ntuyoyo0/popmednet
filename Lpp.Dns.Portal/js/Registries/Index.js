var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var Registries;
(function (Registries) {
    var Index;
    (function (Index) {
        var vm;
        var ViewModel = (function (_super) {
            __extends(ViewModel, _super);
            function ViewModel(gRegistriesSettings, bindingControl, screenPermissions) {
                var _this = _super.call(this, bindingControl, screenPermissions) || this;
                var self = _this;
                _this.ds = new kendo.data.DataSource({
                    type: "webapi",
                    serverPaging: true,
                    serverSorting: true,
                    serverFiltering: true,
                    transport: {
                        read: {
                            url: Global.Helpers.GetServiceUrl("/registries/list"),
                        },
                        parameterMap: function (options, transportType) {
                            var opt = Global.Helpers.UpdateKendoGridFilterOptions(options, [{ field: 'Type', format: "Lpp.Dns.DTO.Enums.RegistryTypes'{0}'" }]);
                            var map = new kendo.data.transports.webapi.parameterMap(opt);
                            return map;
                        }
                    },
                    schema: {
                        model: kendo.data.Model.define(Dns.Interfaces.KendoModelRegistryDTO)
                    },
                    sort: { field: "Name", dir: "asc" },
                });
                Global.Helpers.SetDataSourceFromSettings(_this.ds, gRegistriesSettings);
                _this.onColumnMenuInit = function (e) {
                    var menu = e.container.find(".k-menu").data("kendoMenu");
                    menu.bind("close", function (e) {
                        self.Save();
                    });
                };
                return _this;
            }
            ViewModel.prototype.btnNewRegistry_Click = function () {
                window.location.href = "/registries/details";
            };
            ViewModel.prototype.RegistriesGrid = function () {
                return $("#gRegistries").data("kendoGrid");
            };
            ViewModel.prototype.Save = function () {
                Users.SetSetting("Registries.Index.gRegistries.User:" + User.ID, Global.Helpers.GetGridSettings(this.RegistriesGrid()));
            };
            return ViewModel;
        }(Global.PageViewModel));
        Index.ViewModel = ViewModel;
        function NameAchor(dataItem) {
            return "<a href=\"/registries/details?ID=" + dataItem.ID + "\">" + dataItem.Name + "</a>";
        }
        Index.NameAchor = NameAchor;
        function typeFilterUI(element) {
            element.kendoDropDownList({
                dataSource: Dns.Enums.RegistryTypesTranslation,
                optionLabel: '--Select Value--',
                dataTextField: 'text',
                dataValueField: 'value'
            });
        }
        Index.typeFilterUI = typeFilterUI;
        function init() {
            $.when(Users.GetSetting("Registries.Index.gRegistries.User:" + User.ID), Dns.WebApi.Users.GetGlobalPermission(Permissions.Portal.CreateRegistry)).done(function (gRegistriesSetting, canAdd) {
                $(function () {
                    var bindingControl = $("#Content");
                    vm = new ViewModel(gRegistriesSetting, bindingControl, canAdd[0] ? [Permissions.Portal.CreateRegistry] : []);
                    ko.applyBindings(vm, bindingControl[0]);
                    $(window).unload(function () { return vm.Save(); });
                    Global.Helpers.SetGridFromSettings(vm.RegistriesGrid(), gRegistriesSetting);
                });
            });
        }
        init();
    })(Index = Registries.Index || (Registries.Index = {}));
})(Registries || (Registries = {}));
