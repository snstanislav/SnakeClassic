using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeClassic.PL
{
    /// <summary>
    /// Represents a form that displays a developers tutorial for the Snake Classic game.
    /// </summary>
    /// <remarks>Legacy part of the application from v.1.0 (2011)</remarks>
    public partial class TutorialForm : Form
    {
        /// <summary>
        /// <value>Property <c>TUTORIAL_PAGE_PATH</c></value> and 
        /// <value>property <c>TUTORIAL_STYLE_PATH</c></value>
        /// Constants representing paths to the HTML and CSS files of the tutorial. 
        /// Saved internally in the project as embedded resource.
        /// </summary>
        private const string TUTORIAL_PAGE_PATH = "SnakeClassic.Resources.tutorial.index.html";
        private const string TUTORIAL_STYLE_PATH = "SnakeClassic.Resources.tutorial.styles.css";

        /// <summary>
        /// Initializes the <see cref="TutorialForm"/> and invokes the tutotrial loading method.
        /// </summary>
        public TutorialForm()
        {
            InitializeComponent();
            LoadTutorialDocument();
        }

        /// <summary>
        /// Loads a document from the embedded resources.
        /// </summary>
        /// <param name="resourceName">Represents a path to the document.</param>
        /// <returns>Returns raw content of the document.</returns>
        private string LoadHtmlFromResource(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Loads HTML and CSS documents of the tutorial.
        /// Injects CSS styles into HTML.
        /// Invokes the method to inject source code listings into the HTML content.
        /// </summary>
        private void LoadTutorialDocument()
        {
            try
            {
                string html = LoadHtmlFromResource(TUTORIAL_PAGE_PATH);
                string css = LoadHtmlFromResource(TUTORIAL_STYLE_PATH);

                // Inject CSS into <head>
                int headIndex = html.IndexOf("<head>", StringComparison.OrdinalIgnoreCase);
                if (headIndex != -1)
                {
                    int insertIndex = headIndex + "<head>".Length;
                    html = html.Insert(insertIndex, $"<style>{css}</style>");
                }
                LoadCodeListingsIntoTutorial(html);
            }
            catch (Exception ex)
            {
                tutorialWebBrowser.DocumentText += "SOURCE CODE LISTINGS LOADING ERROR:<br /><br />" + ex.ToString();
                tutorialStatusStrip.Items.Add("Source code listings loading failed...");
            }
        }

        /// <summary>
        /// Injeckts code listings into the HTML content of the tutorial.
        /// Writes the modified HTML to a file and navigates the web browser to it.
        /// </summary>
        /// <param name="html">Represents previously loaded HTML document as string.</param>
        private void LoadCodeListingsIntoTutorial(string html)
        {
            // inject code snippets
            html = html.Replace("<div id=\"listing1-1\"></div>", $"<div id=\"listing1-1\">{LoadHtmlFromResource("SnakeClassic.Resources.tutorial.code_snippets.listing1-1.html")}</div>");

            html = html.Replace("<div id=\"listing1-2\"></div>", $"<div id=\"listing1-1\">{LoadHtmlFromResource("SnakeClassic.Resources.tutorial.code_snippets.listing1-2.html")}</div>");

            html = html.Replace("<div id=\"listing1-3\"></div>", $"<div id=\"listing1-1\">{LoadHtmlFromResource("SnakeClassic.Resources.tutorial.code_snippets.listing1-3.html")}</div>");

            html = html.Replace("<div id=\"listing2-1\"></div>", $"<div id=\"listing1-1\">{LoadHtmlFromResource("SnakeClassic.Resources.tutorial.code_snippets.listing2-1.html")}</div>");

            html = html.Replace("<div id=\"listing2-2\"></div>", $"<div id=\"listing1-1\">{LoadHtmlFromResource("SnakeClassic.Resources.tutorial.code_snippets.listing2-2.html")}</div>");

            html = html.Replace("<div id=\"listing3-1\"></div>", $"<div id=\"listing1-1\">{LoadHtmlFromResource("SnakeClassic.Resources.tutorial.code_snippets.listing3-1.html")}</div>");

            html = html.Replace("<div id=\"listing3-2\"></div>", $"<div id=\"listing1-1\">{LoadHtmlFromResource("SnakeClassic.Resources.tutorial.code_snippets.listing3-2.html")}</div>");

            html = html.Replace("<div id=\"listing3-3\"></div>", $"<div id=\"listing1-1\">{LoadHtmlFromResource("SnakeClassic.Resources.tutorial.code_snippets.listing3-3.html")}</div>");

            html = html.Replace("<div id=\"listing3-4\"></div>", $"<div id=\"listing1-1\">{LoadHtmlFromResource("SnakeClassic.Resources.tutorial.code_snippets.listing3-4.html")}</div>");

            html = html.Replace("<div id=\"listing4-1\"></div>", $"<div id=\"listing1-1\">{LoadHtmlFromResource("SnakeClassic.Resources.tutorial.code_snippets.listing4-1.html")}</div>");

            // Write document to temp file and navigate
            string tempPath = Path.Combine(Path.GetTempPath(), "index.html");
            File.WriteAllText(tempPath, html);
            tutorialWebBrowser.Navigate(tempPath);
            tutorialStatusStrip.Items.Add("Tutorial content loading succeed!");
        }
    }
}