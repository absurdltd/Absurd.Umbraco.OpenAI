angular.module("umbraco")
    .controller("Absurd.OpenAI", function ($scope, $http) {

        var vm = this
        //set default states for flags
        vm.clipboardSuccess = false;
        vm.processing = false;

        //call internal open AI endpoint
        vm.search = function () {
            vm.processing = true;
            $http.get("/umbraco/backoffice/OpenAI/Completion/GetText?text=" + vm.value)
                .then(function success(resp) {
                    vm.resp = resp.data;
                    vm.processing = false;
                }, function error(resp) {
                    vm.resp = resp.data.ExceptionMessage;
                    vm.processing = false;
                });
        };

        //copy to clipboard functionality
        vm.copyClipboard = function () {
            navigator.clipboard.writeText(vm.resp);
            vm.clipboardSuccess = true;
            setTimeout(() => vm.clipboardSuccess = false, 600);
        };
    });