using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class MSUnivLib
    {
        private readonly double[] productTypeCoefficients = { 0, 1.1, 2.5, 8.43 };
        private readonly double[] materialTypeDefectRates = { 0, 0.003, 0.0012 };

        public int CalculateMaterialQuantity(int productType, double width, double length, int count, int materialType)
        {
            // Проверка входных данных
            if (productType < 1 || productType > 3 || materialType < 1 || materialType > 2 || width <= 0 || length <= 0 || count <= 0)
            {
                return -1;
            }

            // Расчет площади продукции
            double area = width * length;

            // Расчет количества сырья без учета брака
            double rawMaterialQuantity = area * productTypeCoefficients[productType] * count;

            // Учет процента брака материала
            double defectRate = materialTypeDefectRates[materialType];
            double totalMaterialQuantity = rawMaterialQuantity * (1 + defectRate);

            // Округление до ближайшего большего целого
            int roundedTotalMaterialQuantity = (int)Math.Ceiling(totalMaterialQuantity);

            return roundedTotalMaterialQuantity;
        }
    }
}
