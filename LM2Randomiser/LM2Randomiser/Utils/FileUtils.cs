﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using LM2Randomiser.Logging;
using LM2Randomiser;

namespace LM2Randomiser.Utils
{
    public abstract class FileUtils
    {
        public static bool GetData(string filePath, int columns, out List<string[]> data)
        {
            List<string[]> temp = new List<string[]>();
            try
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] info = line.Split(',');
                        if (info.Length == columns)
                        {
                            temp.Add(info);
                        }
                        else
                        {
                            Logger.GetLogger.Log("Error in line: {0} of file {1}, column count did not match.", line, filePath);
                            data = null;
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.GetLogger.Log("Error: {1}", ex.Message);
                data = null;
                return false;
            }
            data = temp;
            return true;
        }

        public static bool WriteSpoilers(Randomiser randomiser)
        {
            string currentDir = Directory.GetCurrentDirectory();
            List<Location> placedLocations = randomiser.GetPlacedLocations();

            List<string[]> locationNames;
            if(GetData(Path.Combine(currentDir, "Data\\locations.txt"), 1, out locationNames))
            {
                try
                {
                    using (StreamWriter sr = File.CreateText(Path.Combine(currentDir, "Seed\\spoilers.txt")))
                    {

                        sr.WriteLine("Seed: {0}", randomiser.Seed);
                        sr.WriteLine();

                        foreach (var name in locationNames)
                        {
                            foreach (var location in placedLocations)
                            {
                                if (name[0].Equals(location.name))
                                {
                                    sr.WriteLine("{0} -> {1}", location.name, location.item.name);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.GetLogger.Log("Error: {1}", ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}