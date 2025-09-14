# 📑 Game Design Document (GDD) – Echo Area

## 1. Tổng quan (Overview)
- **Tên tạm**: Echo Area  
- **Thể loại**: Multiplayer Online Battle Arena (MOBA 2.5D, top-down isometric)  
- **Nền tảng**: PC / Mobile  
- **Điểm khác biệt**: Người chơi phải **sử dụng giọng nói thật** để thi triển chiêu thức thay vì bấm nút  

---

## 2. Core Gameplay
- Người chơi chọn **Hero** → mỗi Hero có:
  - **1 Ultimate** (cố định theo Hero)  
  - **1 Skill đỡ đòn** (cố định)  
  - **2 Skill khác** phải **nhặt và học trong trận** (từ bản đồ)  
- **Thi triển chiêu**: đọc đúng câu lệnh (ví dụ: `Fireball!`, `Shield!`, `Storm Rage!`)  
- **Ảnh hưởng của giọng**:
  - Giọng **to** → chiêu mạnh hơn, phạm vi rộng hơn  
  - Giọng **cao/thấp** → biến đổi chiêu (xa hơn/gần hơn)  
- **Combo Voice**: đọc nhanh nhiều câu lệnh liên tiếp → kích hoạt chiêu nâng cao  
- **Nghe lén**: người chơi trong phạm vi gần nghe được chiêu của đối thủ và có thể phản ứng  

---

## 3. Tính năng độc đáo
- **Voice Proximity Chat**: chỉ nghe được người trong phạm vi gần  
- **Voice Distortion**: skin đặc biệt có thể biến dạng giọng  
- **Voice Fatigue**: đọc chiêu quá nhanh → cooldown lâu hơn  
- **Power-up Buff**: tăng độ vang giọng, giảm trễ khi đọc  

---

## 4. Bản đồ & Môi trường
- **Concept map**: một vùng đất linh thiêng, nơi rơi rớt nhiều bí kíp thất truyền → người chơi phải nhặt để học skill  
- **Địa hình ảnh hưởng âm thanh**:
  - **Hang động** → tiếng vang, chiêu mạnh hơn  
  - **Ngoài trời** → giọng tản nhanh, hiệu quả giảm  

---

## 5. Chế độ chơi (Multiplayer Modes)
- **5v5 MOBA** (mode chính, giống Liên Quân / LoL)  
- **3v3 Quick Match** (trận nhanh, vui nhộn)  
- **1v1 Voice Duel** (ai đọc nhanh & chuẩn hơn tung chiêu trước)  

---

## 6. Nghệ thuật & Trình bày (Art Style)
- **Nhân vật + bản đồ 3D**, camera top-down (isometric)  
- **Phong cách Fantasy MOBA** (giống Liên Quân, Dota, LoL)  
- **Hiệu ứng chiêu**: rực rỡ, bắt mắt để bù cho tính hài hước khi người chơi hét chiêu  

---

## 7. Kinh doanh (Monetization)
- **Free to Play**  
- Kiếm tiền từ:
  - **Skin Hero** (mỗi skin có hiệu ứng chiêu & voice riêng)  
  - **Voice Pack**: giọng đọc thay thế (robot, anime, thần thoại…)  
  - **Battle Pass** (nhiệm vụ + thưởng theo mùa)  
