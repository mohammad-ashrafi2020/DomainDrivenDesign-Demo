<div dir="rtl" style="text-align: right;">
  <h1>پروژه آموزش DDD - CQRS - Unit Testing - Web Api و معماری تمیز</h1>
<p>
  موارد استفاده شده در پروژه :
  DDD tactical patterns + CQRS + Clean Arch + MediatR +  SqlServer + MongoDb + Web Api + Unit Testing
  </p>
<p>
  لینک دوره : <a target="_blank" href="https://codeyad.com/c/20c3">  آموزش پیشرفته طراحی نرم افزار با Asp.Net Core</a>
  </p>
  
  <h1>کد های مربوط به Http </h1>
  <ul dir="rtl">
<li><strong>1XX</strong>: اطلاعات – به این معنی که درخواست، پذیرفته شده است یا فرایند همچنان ادامه دارد.</li>
<li><strong>2XX</strong>: تایید می‌کند که عمل با موفقیت انجام شد و یا با موفقیت دریافت شد. همانند کد <b><i>200</i></b></li>
<li><strong>3XX</strong>: راهنمایی مجدد یا هدایت لازم دارد – برای تکمیل درخواست خود، به چیز دیگری نیاز دارد. همانند <b><i>301</i></b></li>
<li><strong>4XX</strong>: خطای سرویس‌گیرنده (سمت کاربر) که نشان می‌دهد درخواست قابلیت تکمیل ندارد یا اینکه کاربر چیزی را نادرست وارد می‌کند.</li>
<li><strong>5XX</strong>: خطای سرویس‌دهنده (سمت سرور) که حاکی از ناتوانی سرور در تکمیل یا انجام درخواستی است که ظاهراَ معتبر بوده است.</li>
</ul>
  <table border="1" style="width: 100%;text-align: right;" dir="rtl">
        <tbody>
            <tr style="height: 22px;">
              <td style="width: 69px; height: 22px;"><b>کد</b></td>
              <td style="width: 458.6px; height: 22px;"><b>معنی کد</b></td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">100</td>
                <td style="width: 458.6px; height: 22px;">ادامه –&nbsp;Continue</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">101</td>
                <td style="width: 458.6px; height: 22px;">پروتکل انتقال –&nbsp;Switching Protocols</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">102</td>
                <td style="width: 458.6px; height: 22px;">پردازش –&nbsp;Processing</td>
            </tr>
            <tr style="height: 22px;background-color: green;">
                <td style="width: 69px; height: 22px;">200</td>
                <td style="width: 458.6px; height: 22px;">حله یا بسیار خوب –&nbsp;OK</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">201</td>
                <td style="width: 458.6px; height: 22px;">ایجاد شده است –&nbsp;Created</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">202</td>
                <td style="width: 458.6px; height: 22px;">پذیرفته شده است –&nbsp;Accepted</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">203</td>
                <td style="width: 458.6px; height: 22px;">اطلاعات غیرمجاز –&nbsp;Non-Authoritative Information</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">204</td>
                <td style="width: 458.6px; height: 22px;">بدون محتوا –&nbsp;No Content</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">205</td>
                <td style="width: 458.6px; height: 22px;">تنظیم مجدد محتوا –&nbsp;Reset Content</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">206</td>
                <td style="width: 458.6px; height: 22px;">محتوای ناقص (جزئی) –&nbsp;Partial Content</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">207</td>
                <td style="width: 458.6px; height: 22px;">چند وضعیتی –&nbsp;Multi-Status</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">300</td>
                <td style="width: 458.6px; height: 22px;">چند گزینه‌ای –&nbsp;Multiple Choices</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">301</td>
                <td style="width: 458.6px; height: 22px;">انتقال دائم (معروف به ریدایرکت 301) –&nbsp;Moved Permanently
                </td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">302</td>
                <td style="width: 458.6px; height: 22px;">تغییر مسیر موقت –&nbsp;Found</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">303</td>
                <td style="width: 458.6px; height: 22px;">دیگری را ببینید –&nbsp;See Other</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">304</td>
                <td style="width: 458.6px; height: 22px;">اصلاح نشده –&nbsp;Not Modified</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">305</td>
                <td style="width: 458.6px; height: 22px;">استفاده از پراکسی –&nbsp;Use Proxy</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">307</td>
                <td style="width: 458.6px; height: 22px;">تغییر مسیر موقت (ریدایرکت موقت) –&nbsp;Temporary Redirect</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">308</td>
                <td style="width: 458.6px; height: 22px;">تغییر مسیر دائم –&nbsp;Permanent Redirect</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;"><span>400</span></td>
                <td style="width: 458.6px; height: 22px;">درخواست بد –&nbsp;Bad Request</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;"><span>401</span></td>
                <td style="width: 458.6px; height: 22px;">غیرمجاز –&nbsp;Unauthorized</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">402</td>
                <td style="width: 458.6px; height: 22px;">پرداخت الزامی است –&nbsp;Payment Required</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;"><span>403</span></td>
                <td style="width: 458.6px; height: 22px;">ممنوع –&nbsp;Forbidden</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;"><span>404</span></td>
                <td style="width: 458.6px; height: 22px;">یافت نشد –&nbsp;Not Found</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">405</td>
                <td style="width: 458.6px; height: 22px;">روش غیرمجاز –&nbsp;Method Not Allowed</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">406</td>
                <td style="width: 458.6px; height: 22px;">غیرقابل پذیرش –&nbsp;Not Acceptable</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">407</td>
                <td style="width: 458.6px; height: 22px;">تایید پراکسی الزامی است –&nbsp;Proxy Authentication Required
                </td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;"><span>408</span></td>
                <td style="width: 458.6px; height: 22px;">مهلت زمانی درخواست، پایان یافته است –&nbsp;Request Time-out
                </td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">409</td>
                <td style="width: 458.6px; height: 22px;">تعارض و یا تضاد –&nbsp;Conflict</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">410</td>
                <td style="width: 458.6px; height: 22px;">رفته (گذشته) –&nbsp;Gone</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">411</td>
                <td style="width: 458.6px; height: 22px;">طول مورد نیاز –&nbsp;Length Required</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">412</td>
                <td style="width: 458.6px; height: 22px;">پیش‌ نیاز لازم انجام نشد –&nbsp;Precondition Failed</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">413</td>
                <td style="width: 458.6px; height: 22px;">موجودیت درخواست خیلی طولانی است –&nbsp;Request Entity Too Large
                </td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">414</td>
                <td style="width: 458.6px; height: 22px;">درخواست نشانی اینترنتی خیلی طولانی است –&nbsp;Request-<abbr title="Uniform Resource Identifier">URI</abbr> Too Large</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">415</td>
                <td style="width: 458.6px; height: 22px;">(این) نوع رسانه پشتیبانی نمی‌شود –&nbsp;Unsupported Media Type
                </td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">416</td>
                <td style="width: 458.6px; height: 22px;">بُعد درخواست، رضایتبخش نیست –&nbsp;Request Range Not Satisfiable
                </td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">417</td>
                <td style="width: 458.6px; height: 22px;">انتظار برآورده نشد –&nbsp;Expectation Failed</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">421</td>
                <td style="width: 458.6px; height: 22px;">درخواست گمراه‌کننده –&nbsp;Misdirected Request</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">422</td>
                <td style="width: 458.6px; height: 22px;">هویت غیرقابل پردازش –&nbsp;Unprocessable Entity</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">423</td>
                <td style="width: 458.6px; height: 22px;">قفل شده –&nbsp;Locked</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">424</td>
                <td style="width: 458.6px; height: 22px;">وابستگی از بین رفت –&nbsp;Failed Dependency</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">425</td>
                <td style="width: 458.6px; height: 22px;">مجموعه نامرتب –&nbsp;Unordered Collection</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">426</td>
                <td style="width: 458.6px; height: 22px;">نیازمند به ارتقارسانی –&nbsp;Upgrade Required</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">428</td>
                <td style="width: 458.6px; height: 22px;">پیش‌نیاز لازم است –&nbsp;Precondition Required</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">429</td>
                <td style="width: 458.6px; height: 22px;">درخواست‌های بسیار زیاد –&nbsp;Too Many Requests</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">431</td>
                <td style="width: 458.6px; height: 22px;">فیلدهای درخواست سرصفحه&nbsp;خیلی بزرگ است –&nbsp;Request Header Fields Too Large</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">451</td>
                <td style="width: 458.6px; height: 22px;">به دلایل قانونی غیرقابل دسترس است –&nbsp;Unavailable For Legal Reasons
                </td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">500</td>
                <td style="width: 458.6px; height: 22px;">خطای سرویس‌دهنده‌ی داخلی –&nbsp;Internal Server Error</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">501</td>
                <td style="width: 458.6px; height: 22px;">قابل اجرا نیست –&nbsp;Not Implemented</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;"><span>502</span></td>
                <td style="width: 458.6px; height: 22px;">دروازه‌ی بد –&nbsp;Bad Gateway</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;"><span>503</span></td>
                <td style="width: 458.6px; height: 22px;">خدمات در دسترس نیست –&nbsp;Service Unavailable</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;"><span>504</span></td>
                <td style="width: 458.6px; height: 22px;">وقفه در دروازه –&nbsp;Gateway Time-out</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">505</td>
                <td style="width: 458.6px; height: 22px;">این نسخه از <abbr title="HyperText Transfer Protocol">HTTP</abbr> قابل پشتیبانی نیست –&nbsp;<abbr title="HyperText Transfer Protocol">HTTP</abbr> Version Not Supported</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">506</td>
                <td style="width: 458.6px; height: 22px;">متغیر قابل انتقال –&nbsp;Variant Also Negotiates</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">507</td>
                <td style="width: 458.6px; height: 22px;">فضا ذخیره‌سازی ناکافی است –&nbsp;Insufficient Storage</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">508</td>
                <td style="width: 458.6px; height: 22px;">حلقه شناسایی شده است –&nbsp;Loop Detected</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">510</td>
                <td style="width: 458.6px; height: 22px;">تمدید نشده –&nbsp;Not Extended</td>
            </tr>
            <tr style="height: 22px;">
                <td style="width: 69px; height: 22px;">511</td>
                <td style="width: 458.6px; height: 22px;">احراز صلاحیت شبکه مورد نیاز است –&nbsp;Network Authentication Required
                </td>
            </tr>
        </tbody>
    </table>
  </div>

