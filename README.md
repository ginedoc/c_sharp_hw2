# c_sharp_hw2
---
姓名：王柏鈞
學號：F74046153
---
## 執行：
	執行檔在
		/hw2/hw2/bin/Debug/hw2.exe
---
## 作業說明：
```flow
st=>start: 開始
ed=>end: 結束
form1=>operation: form1(餐廳端)
form2=>operation: form2(顧客端)
Menu01=>operation: Menu01（點菜畫面）
MoneyMachine=>operation: MoneyMachine(付錢機)
Table=>condition: Custom_table(排座位)

st->form1->form2->Menu01->MoneyMachine->Table
Table(yes)->form1
Table(no)->ed
```
## 各頁面實做說明
餐廳端：
1. 最開始出菜和清理桌面的按鈕 enable 都為 false，直到選擇桌面後才為 true
2. 選擇桌面後，桌子的邊緣(border)會變成Fixed3D 的狀態
3. - 若桌面無客人：綠色
   -   桌面有客人，但未送餐：黃色
   -   桌面有客人，已經送餐：紅色
4. 假如已經有客人，點選送餐或清理都會跳出提醒
5. 若無客人，點選送餐或清理，亦會跳出本桌面無客人的提醒

客戶端：
1. 先詢問客人數量
2. 點菜畫面
	- 滑鼠經過菜名時能預覽食物圖案
	- 勾選checkbox以進行菜色選擇
	- 底下會顯示目前已選的價錢

	- 可以按全部清理鍵一次清空剛剛所選菜餚
	- 按下確定到結帳畫面
3. 結帳畫面
	- 點選付費金額（模擬投幣方式）
		- 每點一次代表投入該金額一次
		- 所付金額大於帳單金額確認鍵才會解鎖，否則 enable 為 false
		- 底下會顯示已經付了的金額，並顯示要找的錢

4.劃位
	- 以藍色代表該顧客將被帶到的座位
