# BRC Otomasyon Projesi - Medya Entegrasyon Kılavuzu

Bu döküman, BRC Otomasyon projesine ait çalışma videoları ve ekran görüntülerinin **GitHub README** dosyasına ve **Kişisel Web Sitenize (brc.html)** en profesyonel şekilde gömülmesi için gerekli kodları ve adımları içerir.

---

## 1. GitHub `README.md` İçin Medya Ekleme (GIF & Görsel)

GitHub'da videolar doğrudan oynatılamaz. Bu yüzden en iyi yöntem, videoyu kısa bir **GIF** yapıp README dosyasına eklemektir.

### Adımlar:
1. Videonuzun en can alıcı 5-10 saniyelik kısmını [ezgif.com](https://ezgif.com/video-to-gif) gibi ücretsiz bir siteden **GIF** formatına dönüştürün.
2. Oluşan GIF dosyasını projedeki `images/` klasörünün altına atın (Örn: `images/smm_demo.gif`).
3. Aşağıdaki kodu `README.md` içinde göstermek istediğiniz yere yapıştırın:

### Markdown Kodu (Copy-Paste):
```markdown
### 🎥 Sistem Çalışma Videosu / System Demo
![SMM Ölçüm ve Barkod Otomasyonu](images/smm_demo.gif)
```

---

## 2. Web Sitesi İçin (`brc.html`) - YouTube Embed Yöntemi (Tavsiye Edilen)

Videoları web sitesinde oynatmanın en performanslı yolu YouTube'a yükleyip siteye gömmektir. Bu sayede web siteniz yavaşlamaz.

### Adımlar:
1. Videonuzu YouTube hesabınıza yükleyin. Gizlilik ayarını **"Liste Dışı" (Unlisted)** yapın (Böylece sadece linke sahip olanlar ve sitenizdekiler izleyebilir).
2. Videonun linkindeki ID'yi alın (Örn: `https://www.youtube.com/watch?v=dQw4w9WgXcQ` linkinde ID `dQw4w9WgXcQ` kısmıdır).
3. `brc.html` dosyasını açın, video göstermek istediğiniz yere aşağıdaki kod bloğunu yapıştırın ve `YOUTUBE_VIDEO_ID` yazan yerleri kendi video ID'niz ile değiştirin.

### HTML Kodu (Copy-Paste):
```html
<!-- BRC Video Oynatıcı Alanı -->
<div class="project-video-section" style="margin: 2.5rem 0; width: 100%;">
    <div style="font-size: 1.25rem; font-weight: 600; color: #0f172a; margin-bottom: 1rem; display: flex; align-items: center; gap: 8px;">
        <span>🎥</span> Proje Çalışma Videosu (Canlı Uygulama)
    </div>
    <div class="video-wrapper" style="position: relative; padding-bottom: 56.25%; height: 0; overflow: hidden; border-radius: 12px; box-shadow: 0 10px 15px -3px rgba(0, 0, 0, 0.1), 0 4px 6px -2px rgba(0, 0, 0, 0.05); border: 1px solid rgba(0,0,0,0.05);">
        <iframe 
            src="https://www.youtube.com/embed/YOUTUBE_VIDEO_ID?rel=0" 
            style="position: absolute; top: 0; left: 0; width: 100%; height: 100%; border: 0;" 
            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" 
            allowfullscreen>
        </iframe>
    </div>
</div>
```

---

## 3. Web Sitesi İçin (`brc.html`) - Doğrudan Sunucudan Oynatma

Eğer videoyu YouTube olmadan doğrudan kendi web sunucunuzdan oynatmak isterseniz bu yöntemi kullanabilirsiniz.

### Adımlar:
1. Videoyu MP4 formatında web sitenizin klasörüne yükleyin (Örn: `videos/brc_demo.mp4`).
2. Aşağıdaki HTML5 kod bloğunu `brc.html` içine yapıştırın:

### HTML Kodu (Copy-Paste):
```html
<!-- BRC Doğrudan Video Oynatıcı -->
<div class="project-video-section" style="margin: 2.5rem 0; width: 100%;">
    <div style="font-size: 1.25rem; font-weight: 600; color: #0f172a; margin-bottom: 1rem;">
        🎥 Proje Çalışma Videosu (Canlı Uygulama)
    </div>
    <video controls poster="../images/projects/brc/banner.jpg" style="width: 100%; border-radius: 12px; box-shadow: 0 10px 15px -3px rgba(0, 0, 0, 0.1); outline: none;">
        <source src="../videos/brc_demo.mp4" type="video/mp4">
        Tarayıcınız video oynatmayı desteklemiyor.
    </video>
</div>
```

---

## 4. Kullanışlı Ücretsiz Medya Araçları
*   **Video Kesme & GIF Yapma:** [ezgif.com](https://ezgif.com) (Kurulum gerektirmez, tarayıcıdan çalışır).
*   **Ekran Kaydı Almak İçin (Ücretsiz & Reklamsız):** **OBS Studio** veya Windows'un kendi ekran kaydedicisi (`Win + Alt + R`).
