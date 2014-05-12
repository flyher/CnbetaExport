using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Road.Net;
using System.Text.RegularExpressions;
using System.Road.Files;
using System.Road.Word;

namespace _2013092401文章导出为txt
{
    public class Export
    {
        HtmlPack hp = new HtmlPack();
        RegexMatch rm = new RegexMatch();
        FileControl fc = new FileControl();
        HtmlFilter hf = new HtmlFilter();

        //处理cnbeta
        public ArtCnbeta HandleCnbeta(string id)
        {
            ArtCnbeta art = new ArtCnbeta();
            try
            {
                HtmlNode htmlnode = hp.GetHtml("http://www.cnbeta.com/articles/" + id + ".htm", "utf-8");
                string html = htmlnode.InnerHtml;
                string txt = htmlnode.InnerText;

                string title = hp.GetAims(htmlnode, "//html/body/div[1]/section[2]/section[1]/article[1]/div[1]/header[1]/h2[1]");
                string datetime = hp.GetAims(htmlnode, "//html/body/div[1]/section[2]/section[1]/article[1]/div[1]/header[1]/div[1]/span[1]");
                //string click=hp.GetAims(htmlnode,"//html/body/div[1]/section[2]/section[1]/article[1]/div[1]/header[1]/div[1]/span[2]/span[1]");
                string wheres = hp.GetAims(htmlnode, "//html/body/div[1]/section[2]/section[1]/article[1]/div[1]/header[1]/div[1]/span[3]/a[1]");
                //string comments=hp.GetAims(htmlnode,"//html/body/div[2]/section[2]/section[1]/article[1]/div[1]/header[1]/div[1]/span[4]/a[1]/font[1]");
                string intro = hp.GetAims(htmlnode, "//html/body/div[1]/section[2]/section[1]/article[1]/div[1]/div[1]/div[1]/p[1]");

                List<string> lst_content = new List<string>();
                Regex r_cn = new Regex("<div class=\"content\">.+</div>");
                lst_content = rm.GetAims(html, r_cn);
                string content = "";
                if (lst_content.Count>0)
	            {
                    content = lst_content[0];
	            }
                //string content = hp.GetAims(htmlnode, "//html/body/div[1]/section[2]/section[1]/article[1]/div[1]/div[1]/div[2]");
                if (title=="-1"||title==""||content=="-1"||content=="")
                {
                    return null;
                }
                if (datetime=="-1")
                {
                    datetime = "";
                }
                if (wheres=="-1")
                {
                    wheres = "";
                }
                if (intro=="-1")
                {
                    intro = "";
                }

                art.url = "http://http://www.cnbeta.com/articles/" + id + ".htm";
                art.title = title;
                art.datetime = datetime;
                art.click = "";
                art.comments = "";
                art.intro = "    " + intro;
                art.content = "    " + content;
                return art;
            }
            catch (Exception)
            {
                return null;
            }
        }
        //导出cnbeta文章
        public string ExportCnbeta(int page, string path)
        {
            try
            {
                ArtCnbeta art = HandleCnbeta(page.ToString());
                if (art != null)
                {
                    string filename = "[" + art.datetime.Substring(0, 10) + " " + page.ToString() + "]" + art.title;
                    string txt = filename + "\r\n" + art.url + "\r\n" + art.datetime + "  " + art.wheres + "\r\n\r\n简介:\r\n" + art.intro + "\r\n\r\n===\r\n  " + ClearHtmlCnbeta(art.content);
                    if (fc.FileSava(path, filename + ".txt", txt) == "1")
                    {
                        return "success:" + art.datetime.Substring(0, 10) + " " + page.ToString();
                    }
                    else
                    {
                        return "failed:" + page.ToString() + " no match!" ;
                    }
                }
                else
                {
                    return "failed:" + page.ToString() + " no article!";
                }
            }
            catch (Exception err)
            {
                return "wrong:" + err.Message.ToString() + "[" + err.StackTrace.ToString() + "]" + err.TargetSite.ToString();
            }
            // return "msg:all page have search!\r\n";
        }
        public ArtEncn HandleEncn(string id)
        {
            ArtEncn art = new ArtEncn();
            try
            {
                HtmlNode htmlnode = hp.GetHtml("http://www.cuyoo.com/home/portal.php?mod=view_both&aid=" + id, "gb2312");
                string html = htmlnode.InnerHtml.Replace("<br><br>", "|");

                List<string> baseen = new List<string>();
                Regex r_en = new Regex("<div id=\"en\">.+</div>");
                baseen = rm.GetAims(html, r_en);
                List<string> basecn = new List<string>();
                Regex r_cn = new Regex("<div id=\"cn\">.+</div>");
                basecn = rm.GetAims(html, r_cn);

                if (baseen.Count == 0 || basecn.Count == 0)
                {
                    return null;
                }
                baseen[0] = ClearHtmlEncn(baseen[0]);
                basecn[0] = ClearHtmlEncn(basecn[0]);

                //string cn = hp.GetAims(htmlnode, "//html/body/table/tr[1]/td[1]/h3");//中英文标题
                string title = hp.GetAims(htmlnode, "//html/body/table/tr[1]/td[1]/h3/h4");//英文标题
                //string en = hp.GetAims(htmlnode, "//html/body/table/tr[2]/td[2]/div/div[1]");
                //string cn = hp.GetAims(htmlnode, "//html/body/table/tr[2]/td[2]/div/div[2]");

                art.id = id;
                art.date = "";
                art.title = title;
                art.en = baseen[0];
                art.cn = basecn[0];
                return art;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public string ExportEncn(int page, string path)
        {
            ArtEncn art = HandleEncn(page.ToString());

            if (art != null)
            {
                string filename = (art.id + "." + art.title).Replace(@"\", "").Replace("#", "").Replace("\n", "").Replace("\r", "").Replace("?", "").Replace(": ", "").Replace(":", "") + ".txt"; ;
                //中英对照
                string[] en = rm.JsonCut(art.en, "|");
                string[] cn = rm.JsonCut(art.cn, "|");
                if (en.Length != cn.Length)
                {
                    //如果中英不对照
                    //直接前面En后面Cn
                    string encn = "";
                    for (int j = 0; j < en.Length; j++)
                    {
                        encn += "    " + en[j] + "\r\n\r\n";
                    }
                    for (int k = 0; k < cn.Length; k++)
                    {
                        encn += "    " + cn[k] + "\r\n\r\n";
                    }
                    if (fc.FileSava(path, filename, encn) == "1")
                    {
                        return "success:" + page.ToString() ;
                    }
                    else
                    {
                        return "failed:" + page.ToString() + " no save!";
                    }
                }
                else//中英文匹配
                {
                    string encn = "";
                    for (int j = 0; j < en.Length; j++)
                    {
                        encn += "    " + en[j] + "\r\n\r\n" + "    " + cn[j] + "\r\n\r\n";
                    }
                    if (fc.FileSava(path, filename, encn) == "1")
                    {
                        return "success:" + page.ToString();
                    }
                    else
                    {
                        return "failed:" + page.ToString() + " no save!";
                    }
                }
            }
            else
            {
                return "failed:" + page.ToString() + " no match!";
            }
        }
        

        /// <summary>
        /// 除去文章中无用标签
        /// </summary>
        /// <param name="str">文章内容</param>
        /// <returns></returns>
        public string ClearHtmlCnbeta(string str)
        {
            return str.Replace("：", ":").Replace("。", ".").Replace("，", ",")
                .Replace("<div class=\"content\">", "").Replace("</div>", "")
                .Replace("</p>", "").Replace("<p>", "\r\n    ")
                .Replace("<br/>", "\r\n").Replace("<br>", "\r\n")
                .Replace("</strong>", "").Replace("<strong>", "  ")
                .Replace("<span>", "").Replace("</span>", "")
                .Replace(" style=\"text-align:center\"", "").Replace(" style=\"text-align: center;\"", "")
                .Replace("  ", " ")
                .Replace("<a target=\"_blank\" href=\"", "[图片]")
                .Replace("<img src=\"", "[图片]")
                .Replace("\" alt=\"UX Shootout\"", "")
                .Replace("</a>", "")
                .Replace("<b>", "").Replace("</b>", "")
                .Replace("<a href=\"","").Replace("\">","")
                .Replace("width=\"","").Replace("height=\"","")
                ;
        }
        public string ClearHtmlEncn(string str)
        {
            return str.Replace("<div id=\"en\">", "").Replace("<div id=\"cn\">", "").
                Replace("|</div>", "").Replace("<div>", "").Replace("</div>", "").
                Replace("<br>", "").Replace("<li>", "").Replace("</li>", "").
                Replace("<b>", "").Replace("</b>", "").Replace("<i>", "").
                Replace("</i>", "").Replace("<", "").Replace(">", "");
        }
    }
}
