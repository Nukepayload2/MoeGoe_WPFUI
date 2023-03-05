# MoeGoe_WPFUI
WPF GUI for [MoeGoe](https://github.com/CjangCjengh/MoeGoe). The core logics of this app is converted from [MoeGoe_GUI](https://github.com/CjangCjengh/MoeGoe_GUI).

This app is localized for `zh-CN` only. Other display languages are not supported yet.

This project is currently working in progress. 

- [x] Put the original version of [MoeGoe_GUI](https://github.com/CjangCjengh/MoeGoe_GUI) to the `PendingRefactorCode` folder
- [x] Draw the UI with WPF.
- [ ] Migrate WinForms UI code to WPF.
- [ ] Refactor code to take advantage of WPF and .NET Runtime features. 
    - [ ] Use JSON libraries instead of regex to handle JSON.
    - [ ] Use VB `MySettings` to manage settings.
    - [ ] Use MVVM pattern to reduce class coupling.
- [ ] User experience improvements
    - [x] Support Window resizing
    - [ ] Support Per-Monitor V2 DPI scaling
    - [ ] Remember last dialog selection
