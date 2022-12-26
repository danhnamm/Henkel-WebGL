var DownloadFilePlugin = {
  DownloadFile : function(array, size, fileNamePtr)
  {
    var fileName = UTF8ToString(fileNamePtr);
    var bytes = new Uint8Array(size);
    for (var i = 0; i < size; i++) { bytes[i] = HEAPU8[array + i]; }
    var blob = new Blob([bytes]);
    SetBlobPNG(blob);
  }
};
mergeInto(LibraryManager.library, DownloadFilePlugin);