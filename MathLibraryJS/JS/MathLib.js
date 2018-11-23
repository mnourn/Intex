function nodes() {
    this.head = null;
}

nodes.prototype = {
    add: function (value) {
        if (value > 0) {
            if (this.head == null) {
                this.head = {
                    value: value % 100,
                    next: null
                };
                var last = this.head;
                value = Math.floor(value / 100);
                while (value > 0) {
                    var tmp = {
                        value: value % 100,
                        next: null
                    };
                    value = Math.floor(value / 100);
                    last.next = tmp;
                    last = tmp;
                }
            }
            else {
                var last = this.head;
                while (value > 0) {
                    var add = value % 100;
                    var remain = Math.floor((last.value + add) / 100);
                    last.value = (last.value + add) % 100;
                    value = Math.floor(value / 100);
                    value = value + remain;
                    if (value > 0) {
                        if (last.next == null) {
                            var tmp = {
                                value: 0,
                                next: null
                            };
                            last.next = tmp;
                            last = tmp;
                        }
                        else {
                            last = last.next;
                        }
                    }
                }
            }
        }
    },
    multiply: function (value) {
        var head = {
            value: 0,
            next: null
        };
        var result = new nodes();
        result.head = head;
        if (this.head != null) {
            if (value != 0) {
                var index = 0;
                while (value > 0) {
                    var lastSource = this.head;
                    var lastDestination = result.head;
                    var val = value % 100;
                    for (var i = 0; i < index && lastDestination != null; i++) {
                        lastDestination = lastDestination.next;
                    }
                    var newVal = 0;
                    while (lastSource != null) {
                        newVal += val * lastSource.value;
                        var add = newVal % 100;
                        var remain = Math.floor((lastDestination.value + add) / 100);
                        lastDestination.value = (lastDestination.value + add) % 100;
                        newVal = Math.floor(newVal / 100);
                        newVal += remain;
                        lastSource = lastSource.next;
                        if (lastDestination.next == null && (lastSource != null || newVal > 0)) {
                            var tmp = {
                                value: 0,
                                next: null
                            };
                            lastDestination.next = tmp;
                        }
                        lastDestination = lastDestination.next;
                    }
                    if (newVal > 0) {
                        lastDestination.value = newVal;
                    }
                    value = Math.floor(value / 100);
                    index++;
                }
            }
            else {
                result.head = {
                    value: 0,
                    next: null
                };
            }
        }
        return result;
    },
    factorial: function (value) {
        var result = new nodes();
        result.head = {
            value: 1,
            next: null
        };
        for (var i = 2; i <= value; i++) {
            result = result.multiply(i);
        }
        return result;
    },
    getValue: function () {
        var result = '';
        var tmp = this.head;
        while (tmp != null) {
            result = (tmp.value > 10 || tmp.next == null ? tmp.value : "0" + tmp.value) + result;
            tmp = tmp.next;
        }
        return result;
    }
}