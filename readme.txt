// ==================================   使用者介面相關   =====================================
// Load 按鈕事件處理函式
private void button1_Click(object sender, EventArgs e)

// 一般處理方式: 灰階化範例
private void button2_Click(object sender, EventArgs e) 

// 高效率影像處理 --  反轉顏色範例
private void button3_Click(object sender, EventArgs e) 

// 高效率影像處理 --  紅色濾鏡範例
private void button4_Click(object sender, EventArgs e) 

// 高效率影像處理 --  綠色濾鏡範例
private void button5_Click(object sender, EventArgs e) 

// 高效率影像處理範例 --  藍色濾鏡範例
private void button6_Click(object sender, EventArgs e) 

// 高效率影像處理範例 --  增加亮度
private void button7_Click(object sender, EventArgs e) 


// ==================================   影像處理公用程式相關   =====================================
public void ColorFilter(int Select)


// 建立一個專門秀圖的 Form 類別
class ImageForm : Form {

// 預設建構子建構子
public ImageForm()

// 建構子
public ImageForm(String Filename)

//
public void LoadImage(String Filename)
protected override void OnPaint(PaintEventArgs e)

// 傳回 RGB 陣列資訊
public int[,,] getRGBData()

//
public void doGray(int[,,]rgbData)
public void Invert()

// 高效率反轉圖片 
public static bool Invert(Bitmap bimage)

// 高效率圖形轉換工具 -- 讀取影像資料
public int[, ,] getRGBData_unsafe()
public static int[, ,] getRGBData(Bitmap bimage)

// 高效率圖形轉換工具 -- 由陣列建立新的 Bitmap
public void setRGBData_unsafe(int[, ,] rgbData)
public static Bitmap CreateBitmap(int[, ,] rgbData)

}



