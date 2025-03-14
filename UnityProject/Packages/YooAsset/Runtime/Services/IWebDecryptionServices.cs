using System.IO;
using UnityEngine;

namespace YooAsset
{
    public struct WebDecryptFileInfo
    {
        /// <summary>
        /// 资源包名称
        /// </summary>
        public string BundleName;

        /// <summary>
        /// Unity引擎用于内容校验的CRC
        /// </summary>
        public uint FileLoadCRC;

        /// <summary>
        /// 文件字节数据
        /// </summary>
        public byte[] FileData;
    }
    public struct WebDecryptResult
    {
        /// <summary>
        /// 资源包对象
        /// </summary>
        public AssetBundle Result;
    }

    public interface IWebDecryptionServices
    {
        WebDecryptResult LoadAssetBundle(WebDecryptFileInfo fileInfo);
    }
}