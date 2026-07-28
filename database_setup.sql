-- database_setup.sql
-- Run this script in SQL Server Management Studio (SSMS) to prepare the database for the SCADA application.

CREATE DATABASE PC_DATA;
GO

USE PC_DATA;
GO

-- Create the main production measurements table
CREATE TABLE urun_db (
    Id INT NOT NULL PRIMARY KEY, -- Received directly from the PLC
    Sag_305_X FLOAT NULL,
    Sol_305_1_X FLOAT NULL,
    Sag_kol_boy_290_Y FLOAT NULL,
    Sol_kol_boy_290_1_Y FLOAT NULL,
    Sonuc NVARCHAR(50) NULL,
    Cevrim_Suresi NVARCHAR(50) NULL,
    Tutkal_Sicaklik FLOAT NULL,
    Ortam_Nem FLOAT NULL,
    Ortam_Sicaklik FLOAT NULL,
    Tarih NVARCHAR(50) NULL,
    Saat NVARCHAR(50) NULL,
    Kaciklik1 FLOAT NULL,
    Kaciklik2 FLOAT NULL,
    Kaciklik3 FLOAT NULL,
    Kaciklik4 FLOAT NULL,
    Kaciklik5 FLOAT NULL,
    Kaciklik6 FLOAT NULL,
    Kaciklik7 FLOAT NULL,
    Kaciklik8 FLOAT NULL,
    Kaciklik9 FLOAT NULL,
    Kaciklik10 FLOAT NULL
);
GO

-- Create the system alarms log table
CREATE TABLE alarm_db (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Tarih NVARCHAR(50) NULL,
    Kod NVARCHAR(50) NULL,
    Mesaj NVARCHAR(255) NULL,
    Durum NVARCHAR(50) NULL
);
GO

-- Insert default simulation alarms
INSERT INTO alarm_db (Tarih, Kod, Mesaj, Durum) VALUES 
('27.07.2026 19:12:04', 'A012', 'Sağ Aks Servo Sürücü Aşırı Akım Hatası', 'Temizlendi'),
('27.07.2026 19:15:30', 'A045', 'Hava Basıncı Limit Dışı (< 5.5 Bar)', 'Temizlendi'),
('27.07.2026 20:30:11', 'A089', 'Tutkal Kazanı Sıcaklığı Yüksek (> 180°C)', 'Temizlendi'),
('27.07.2026 21:05:44', 'A003', 'Acil Stop Butonu Basılı (E-Stop)', 'Temizlendi'),
('27.07.2026 21:38:12', 'A022', 'Sol Sensör PLC Haberleşme Hatası', 'Aktif');
GO
