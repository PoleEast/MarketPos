﻿# WinForm商店POS

`Deadline:5/20 AM9:20`

## 系統概述

本系統旨在為商店提供一套完整的POS管理解決方案，涵蓋銷售、訂單、庫存、會員、財務等各個方面。系統採用現代化的軟件開發技術，具有易用、高效、安全的特點。

### 系統功能

#### 訂購表單

- 瀏覽商品、訂購商品
  - [x] 設定自訂一商品控件(將圖片、購物車、詳細頁面、價格、庫存數、評分)
  - [x] 將商品顯示在UI上(暫定8*2)
  - [x] 提供使用者翻頁的功能(頁數、上下頁)
  - [x] 允許使用者通過關鍵字搜索商品
  - [x] 允許使用者根據價格範圍、類別等條件篩選商品。
- 購物車、結帳、預定
  - [x] 將使用者未結清單顯示出來
  - [x] 提供刪改資料的功能
  - [x] 提供付款選項、資料輸入
  - [ ] 出貨天數
  - [ ] 預定缺貨物品
  - [x] 顯示購物車中有幾種商品與總金額

#### 會員註冊表單

- 會員功能
  - [x] 註冊、登入功能
  - [x] 更改會員資料(地址、電話、e-mail、常用地址、密碼)
  - [x] 歷史訂單查詢
  - [ ] 退貨功能
  - [ ] 使用者回饋表單
  - [ ] 評價商品
  - [ ] 最近觀看清單

#### 商品管理

- 商品狀態查詢
  - [x] 查看商品的數量
  - [x] 商品庫存狀況
  - [ ] 查看商品評價
  - [ ] 商品保存期限與進貨日期
- 商品管理
  - [x] 商品類型調整
  - [x] 商品價格調整
  - [ ] 商品圖片調整
  - [ ] 有無打折或回饋活動
  - [x] 商品上下架

#### 訂單管理

- 訂單格式
  - 訂單編號
  - 訂購時間
  - 會員名稱
  - 訂購品項、數量
  - 訂單金額
  - 是否出貨
  - 是否退貨
  - 最晚到達日
- 訂單管理
  - [x] 訂單審核
  - [x] 訂單取消
  - [x] 訂單細項管理

#### 財報檢視

- 財務報表
  - [x] 查詢訂單(指定日期、品項等等)
  - [ ] 更具查詢計算營業額、數量
  - [ ] 各類商品銷售狀況
  - [ ] 會員活耀度、訂購狀況
  - [ ] bouns:商品毛利率計算

#### 系統管理

- 系統相關設定
  - [ ] 系統運作時間
  - [ ] 系統路徑
  - [ ] 權限安全
  - [ ] 管理者帳號管理
  - [ ] 紀錄系統操作日誌，包括登入、訂單修改、商品管理等操作的記錄
  - [ ] Super Bouns:系統備份與還原
  
### 系統開發

#### 技術架構

- 前端：採用WinForm技術，開發桌面用戶界面。
- 後端：採用ASP.NETCore框架。
- 資料庫：採用SQL Server資料庫，存儲系統資料。

### 測試用帳號密碼資料

coolman asdasd
sa 123456