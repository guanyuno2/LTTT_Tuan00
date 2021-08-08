Câu 1. Cho tập tin adjacency-matrix.txt chứa ma trận kề biểu diễn một đồ thị. Tập tin có định
dạng như sau:
▪ Dòng đầu tiên chứa số nguyên n (n > 2) thể hiện số đỉnh của đồ thị.
▪ n dòng tiếp theo chứa n số nguyên trên mỗi dòng, các số nguyên cách nhau bằng khoảng
trắng. Gọi [i, j] là giá trị tại dòng i cột j (i, j = 0,....n-1). [i, j] = 0: không có cạnh nối từ đỉnh
i đến đỉnh j, và [i, j] = 1: có cạnh nối từ đỉnh i đến đỉnh j.
Gọi AdjacencyMatrix là cấu trúc/lớp biểu diễn thông tin của một đồ thị, chứa ít nhất hai thành
phần cơ bản là số đỉnh của đồ thị (số nguyên không âm) và ma trận kề tương ứng với đồ thị
(mảng 2 chiều n  n gồm các số nguyên không âm hoặc sinh viên có thể sử dụng cấu trúc dữ
liệu khác tối ưu hơn) . Khai báo một biến AM có kiểu AdjacencyMatrix.
Đọc nội dung tập tin vào biến AM rồi in ra màn hình các nội dung sau:
a. Số đỉnh của đồ thị.
b. Ma trận kề biểu diễn đồ thị.
c. Kiểm tra tính đối xứng của ma trận. Nếu ma trận đối xứng, in ra màn hình chuỗi “Ma
tran doi xung”, ngược lại in chuỗi “Ma trận không đối xứng”.

Câu 2. Cho tập tin adjacency-list.txt chứa danh sách kề biểu diễn một đồ thị. Tập tin có định
dạng như sau:
▪ Dòng đầu tiên chứa số nguyên n (n > 2) thể hiện số đỉnh của đồ thị.
▪ n dòng tiếp theo lần lượt chứa thông tin danh sách kề của đỉnh 0 đến đỉnh n-1.
▪ Danh sách kề của mỗi đỉnh i được biểu diễn bằng mi + 1 số nguyên, trong đó số nguyên
đầu tiên là số lượng đỉnh có cạnh nối xuất phát từ đỉnh i (tức là mi) và các số nguyên
tiếp theo là chỉ mục của những đỉnh kề (chỉ mục tính từ 0)
Gọi AdjacencyList là cấu trúc/lớp biểu diễn thông tin của một đồ thị, chứa ít nhất hai thành
phần cơ bản là số đỉnh của đồ thị (số nguyên không âm) và danh sách kề tương ứng với đồ thị
(mảng 2 chiều gồm các số nguyên không âm, hoặc sinh viên có thể sử dụng cấu trúc dữ liệu
khác tối ưu hơn). Khai báo một biến AL có kiểu AdjacencyList.
Đọc nội dung tập tin vào biến AL rồi in ra màn hình các nội dung sau:
a. Số đỉnh của đồ thị.
b. Danh sách kề biểu diễn đồ thị.
c. Kiểm tra với mỗi cặp đỉnh, gọi là A và B, có cạnh nối trên đồ thị, rằng từ A có thể đi đến B
VÀ từ B có thể đi đến A. Nếu mọi cặp đỉnh đều thỏa, in ra màn hình chuỗi “Danh sach ke
bieu dien do thi hai chieu”, ngược lại in chuỗi “Danh sach ke bieu dien do thi mot chieu”.

Câu 3. Cho tập tin adjacency-matrix.txt chứa ma trận kề biểu diễn một đồ thị. Khai báo biến
AM có kiểu AdjacencyMatrix và biến AL có kiểu AdjacencyList. Đọc nội dung tập tin vào biến
AM. Chuyển đổi thông tin có trong AM vào AL. Ghi nội dung của AL vào tập tin adjacency-
list.txt.
Định nghĩa của AdjacencyMatrix và AdjacencyList, và định dạng của tập tin adjacency-
matrix.txt và adjacency-list được mô tả ở phần trên.

Câu 4. Cho tập tin adjacency-list.txt chứa ma trận kề biểu diễn một đồ thị. Khai báo biến AM
có kiểu AdjacencyMatrix và biến AL có kiểu AdjacencyList. Đọc nội dung tập tin vào biến AL.
Chuyển đổi thông tin có trong AL vào AM. Ghi nội dung của AM vào tập tin adjacency-
matrix.txt.
Định nghĩa của AdjacencyMatrix và AdjacencyList, và định dạng của tập tin adjacency-
matrix.txt và adjacency-list được mô tả ở phần trên.