using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DorkHunter
{
    public partial class DorkHunter : Form
    {

        public DorkHunter()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:.s3.amazonaws.com " + "\"" + Uri.EscapeDataString(textBox1.Text) + "\"");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " filetype:config " + "\"" + "apache" + "\"");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site%3Aatlassian.net+|+site%3Abitbucket.org+" + "\"" + Uri.EscapeDataString(textBox1.Text) + "\"");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " ext:bkf | ext:bkp | ext:bak | ext:old | ext:backup");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://censys.io/certificates?q=" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://censys.io/domain?q=" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://censys.io/ipv4?q=" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://crt.sh/?q=" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://whatcms.org/?s=" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + Uri.EscapeDataString(textBox1.Text) + "/crossdomain.xml");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " ext:sql | ext:dbf | ext:mdb | ext:accdb | ext:db | ext:sqlite | ext:sqlite3 | ext:bak | ext:backup");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:digitaloceanspaces.com " + "\"" + Uri.EscapeDataString(textBox1.Text) + "\"");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " intitle:index.of");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " ext:doc | ext:docx | ext:odt | ext:pdf | ext:rtf | ext:sxw | ext:psw | ext:ppt | ext:pptx | ext:pps | ext:csv");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:*.*." + Uri.EscapeDataString(textBox1.Text));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=inurl:" + "\"" + "/.git " + "\"" + Uri.EscapeDataString(textBox1.Text) + " -github ");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gist.github.com/search?q=*." + "\"" + Uri.EscapeDataString(textBox1.Text) + "\"");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " inurl:/.git/config | inurl:/.svn/entries");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/search?q=" + "\"" + "*." + Uri.EscapeDataString(textBox1.Text) + "\"");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=inurl:gitlab " + Uri.EscapeDataString(textBox1.Text));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cse.google.com/cse?cx=002972716746423218710:veac6ui3rio#gsc.tab=0&gsc.q=" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:linkedin.com employees " + Uri.EscapeDataString(textBox1.Text));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " ext:log");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " inurl:login | inurl:signin | intitle:Login | intitle: signin | inurl:auth");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " inurl:redir | inurl:url | inurl:redirect | inurl:return | inurl:src=http | inurl:r=http");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.openbugbounty.org/search/?search=" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastebin.com " + Uri.EscapeDataString(textBox1.Text));
        }

        private void button28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " ext:php intitle:phpinfo \"published by the PHP Group\"");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " inurl:" + "\"" + "/phpinfo.php" + "\"" + " | inurl:" + "\"" + ".htaccess" + "\"");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://publicwww.com/websites/" + "\"" + Uri.EscapeDataString(textBox1.Text) + "\"" + "/");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site%3Ahttp%3A%2F%2Fideone.com+|+site%3Ahttp%3A%2F%2Fcodebeautify.org+|+site%3Ahttp%3A%2F%2Fcodeshare.io+|+site%3Ahttp%3A%2F%2Fcodepen.io+|+site%3Ahttp%3A%2F%2Frepl.it+|+site%3Ahttp%3A%2F%2Fjustpaste.it+|+site%3Ahttp%3A%2F%2Fpastebin.com+|+site%3Ahttp%3A%2F%2Fjsfiddle.net+|+site%3Ahttp%3A%2F%2Ftrello.com+|+site%3A*.atlassian.net+|+site%3Abitbucket.org+" + "\"" + Uri.EscapeDataString(textBox1.Text) + "\"");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + "  inurl:readme | inurl:license | inurl:install | inurl:setup | inurl:config");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/search/?q=" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button34_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://viewdns.info/reverseip/?host=" + Uri.EscapeDataString(textBox1.Text) + "&t=1");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://community.riskiq.com/search/" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button36_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + Uri.EscapeDataString(textBox1.Text) + "/robots.txt");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://securityheaders.com/?q=" + Uri.EscapeDataString(textBox1.Text) + "&followRedirects=on");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " ext:xml | ext:conf | ext:cnf | ext:reg | ext:inf | ext:rdp | ext:cfg | ext:txt | ext:ora | ext:ini");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=.sharepoint.com/_vti_bin/webpartpages/asmx -docs -msdn -mdsec site:" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button40_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.shodan.io/search?query=" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button41_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://domaineye.com/similar/" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button42_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " intext:\"sql syntax near\" | intext:\"syntax error has occurred\" | intext:\"incorrect syntax near\" | intext:\"unexpected end of SQL command\" | intext:\"Warning: mysql_connect()\" | intext:\"Warning: mysql_query()\" | intext:\"Warning: pg_connect()\"");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:stackoverflow.com " + "\"" + Uri.EscapeDataString(textBox1.Text) + "\"");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " ext:action | ext:struts | ext:do");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=inurl:" + Uri.EscapeDataString(textBox1.Text) + " ext:swf");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yandex.com/search/?text=site:" + Uri.EscapeDataString(textBox1.Text) + "  mime:swf");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://threatcrowd.org/domain.php?domain=" + Uri.EscapeDataString(textBox1.Text));
        }

        private void button48_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:throwbin.io " + Uri.EscapeDataString(textBox1.Text));
        }

        private void button49_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=intitle:traefik+inurl:8080/dashboard" + "\"" + Uri.EscapeDataString(textBox1.Text) + "\"");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.archive.org/web/*/" + Uri.EscapeDataString(textBox1.Text) + "/*");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.archive.org/cdx/search?url=" + Uri.EscapeDataString(textBox1.Text) + "/&matchType=domain&collapse=urlkey&output=text&fl=original&filter=mimetype:application/x-shockwave-flash&limit=100000");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.archive.org/cdx/search?url=" + Uri.EscapeDataString(textBox1.Text) + "/&matchType=domain&collapse=urlkey&output=text&fl=original&filter=urlkey:.*swf&limit=100000");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://wwwb-dedup.us.archive.org:8083/cdx/search?url=" + Uri.EscapeDataString(textBox1.Text) + "/&matchType=domain&collapse=digest&output=text&fl=original,timestamp&filter=urlkey:.*wp[-].*&limit=1000000&xx=");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + "  inurl:shell | inurl:backdoor | inurl:wso | inurl:cmd | shadow | passwd | boot.ini | inurl:backdoor");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:*." + Uri.EscapeDataString(textBox1.Text));
        }

        private void button56_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " inurl:wp-content | inurl:wp-includes");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " inurl:wp- | inurl:wp-content | inurl:plugins | inurl:uploads | inurl:themes | inurl:download");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " inurl:/wp-config.php ext:php");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:" + Uri.EscapeDataString(textBox1.Text) + " filetype:wsdl | filetype:WSDL | ext:svc | inurl:wsdl | Filetype: ?wsdl | inurl:asmx?wsdl | inurl:jws?wsdl | intitle:_vti_bin/sites.asmx?wsdl | inurl:_vti_bin/sites.asmx?wsdl");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/results?search_query=" + Uri.EscapeDataString(textBox1.Text));
        }
    }
}
