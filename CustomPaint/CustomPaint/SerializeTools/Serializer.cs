using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using Newtonsoft.Json;
using System.Windows.Forms;
using CustomPaint.Actions;
using CustomPaint.Figures;

namespace CustomPaint.SerializerTools
{
    public class Serializer
    {
        readonly JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        };

        private OpenFileDialog openDialog = new OpenFileDialog();
        private SaveFileDialog saveDialog = new SaveFileDialog();

        public void Serialize(Storage figureStorage)
        {
            JsonSerializer serializer = JsonSerializer.Create(settings);

            try
            {
                saveDialog.DefaultExt = ".json";
                saveDialog.Filter = "JSON files (*.json)|*json";
                saveDialog.ShowDialog();
                string fileName = saveDialog.FileName;

                if (fileName != "")
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileName))
                    {
                        using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
                        {
                            serializer.Serialize(jsonWriter, figureStorage);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pofixil ＼(￣▽￣)／", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Storage Deserialize(Storage currentFigureStorage)
        {
            try
            {
                Storage figureStorage = new Storage();

                openDialog.ShowDialog();
                string fileName = openDialog.FileName;

                if (fileName != "")
                {
                    using (var fStream = File.OpenRead(fileName))
                    {
                        string streamReader = new StreamReader(fStream).ReadToEnd();
                        figureStorage = JsonConvert.DeserializeObject<Storage>(streamReader, settings);
                    }
                    return figureStorage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pofixil ＼(￣▽￣)／", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return currentFigureStorage;
        }

        
    }
}
