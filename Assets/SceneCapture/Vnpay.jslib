mergeInto(LibraryManager.library, {
    FaceBookInit: function (id) {
        InitFB(Pointer_stringify(id));
    },
    FaceBookShare: function (linkImage) {
        var imgLink = Pointer_stringify(linkImage);
        document.onpointerup = function() { //Use onpointerup for touch input compatibility
             ShareSnapShot(imgLink);
             document.onpointerup = null;
         }
    },
    OpenWindow: function(link) {
         var url = Pointer_stringify(link);
         document.onpointerup = function() { //Use onpointerup for touch input compatibility
             window.open(url);
             document.onpointerup = null;
         }
     },
     RequestedConfirmNative: function(link) {
         RequestedConfirm();    
     },
     PushEventNative: function(eventName) {
         var event = Pointer_stringify(eventName);
         pushEvent(event);
     },
     GetNativeCode: function() {
         getURLParam();
     },
});