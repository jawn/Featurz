﻿'use strict';

angular.module('version', [])

    .directive('appVersion', ['version', function (version) {
    	return function (scope, elm, attrs) {
    		elm.text(version);
    	};
    }]);