using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

[Token(Token = "0x2003C69")]
public class UMAAssetIndexer : MonoBehaviour, _Attribute
{
	[Token(Token = "0x2003C6A")]
	public enum EAssetItemType
	{
		[Token(Token = "0x4019AFB")]
		EAssetItemType_Slot,
		[Token(Token = "0x4019AFC")]
		EAssetItemType_Overlay,
		[Token(Token = "0x4019AFD")]
		EAssetItemType_Race,
		[Token(Token = "0x4019AFE")]
		EAssetItemType_TextRecipe,
		[Token(Token = "0x4019AFF")]
		EAssetItemType_WardrobeRecipe,
		[Token(Token = "0x4019B00")]
		EAssetItemType_MAX
	}

	[Serializable]
	[Token(Token = "0x2003C6B")]
	public class AssetItem
	{
		[Token(Token = "0x4019B01")]
		[FieldOffset(Offset = "0x8")]
		public string _QualifiedName;

		[Token(Token = "0x4019B02")]
		[FieldOffset(Offset = "0xC")]
		public int _TypeIndex;

		[Token(Token = "0x4019B03")]
		[FieldOffset(Offset = "0x10")]
		public string _Name;

		[Token(Token = "0x4019B04")]
		[FieldOffset(Offset = "0x14")]
		public Object _Item;

		[Token(Token = "0x4019B05")]
		[FieldOffset(Offset = "0x18")]
		public string _Path;

		[Token(Token = "0x17001993")]
		public Type _Type
		{
			[Token(Token = "0x60181F0")]
			[Address(RVA = "0x35F1A38", Offset = "0x35F1A38", VA = "0x35F1A38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001994")]
		public string _AssetBaseName
		{
			[Token(Token = "0x60181F2")]
			[Address(RVA = "0x35F2E20", Offset = "0x35F2E20", VA = "0x35F2E20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001995")]
		public string AssetName
		{
			[Token(Token = "0x60181F3")]
			[Address(RVA = "0x35F2EA8", Offset = "0x35F2EA8", VA = "0x35F2EA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001996")]
		public string EvilName
		{
			[Token(Token = "0x60181F4")]
			[Address(RVA = "0x35F2360", Offset = "0x35F2360", VA = "0x35F2360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60181EE")]
		[Address(RVA = "0x35F1618", Offset = "0x35F1618", VA = "0x35F1618")]
		public AssetItem(Type Type, string Name, string Path, Object Item)
		{
		}

		[Token(Token = "0x60181EF")]
		[Address(RVA = "0x35F2CD8", Offset = "0x35F2CD8", VA = "0x35F2CD8")]
		public AssetItem(Type Type, Object Item)
		{
		}

		[Token(Token = "0x60181F1")]
		[Address(RVA = "0x35F2D90", Offset = "0x35F2D90", VA = "0x35F2D90")]
		public void ConvertToType()
		{
		}

		[Token(Token = "0x60181F5")]
		[Address(RVA = "0x35F2ED4", Offset = "0x35F2ED4", VA = "0x35F2ED4")]
		public void CheckName()
		{
		}
	}

	[Token(Token = "0x4019AEE")]
	public const string IndexPath = "/InternalDataStore/InGame/Resources/AssetIndexer";

	[Token(Token = "0x4019AEF")]
	[FieldOffset(Offset = "0x0")]
	public static string SortOrder;

	[Token(Token = "0x4019AF0")]
	[FieldOffset(Offset = "0x4")]
	public static string[] SortOrders;

	[Token(Token = "0x4019AF1")]
	[FieldOffset(Offset = "0x8")]
	public static Dictionary<Type, Type> TypeToLookup;

	[Token(Token = "0x4019AF2")]
	[FieldOffset(Offset = "0xC")]
	private static Type[] Types;

	[Token(Token = "0x4019AF3")]
	[FieldOffset(Offset = "0xC")]
	public List<string> IndexedTypeNames;

	[Token(Token = "0x4019AF4")]
	[FieldOffset(Offset = "0x10")]
	public List<AssetItem> Items;

	[Token(Token = "0x4019AF5")]
	[FieldOffset(Offset = "0x14")]
	public UMAMeshAsset BaseMaleBone;

	[Token(Token = "0x4019AF6")]
	[FieldOffset(Offset = "0x18")]
	public UMAMeshAsset BaseFemaleBone;

	[Token(Token = "0x4019AF7")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<Type, Dictionary<string, AssetItem>> TypeLookup;

	[Token(Token = "0x4019AF8")]
	[FieldOffset(Offset = "0x10")]
	private static GameObject theIndex;

	[Token(Token = "0x4019AF9")]
	[FieldOffset(Offset = "0x14")]
	private static UMAAssetIndexer theIndexer;

	[Token(Token = "0x17001992")]
	public static UMAAssetIndexer Instance
	{
		[Token(Token = "0x60181D5")]
		[Address(RVA = "0x35F00B4", Offset = "0x35F00B4", VA = "0x35F00B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60181D2")]
	[Address(RVA = "0x35EFD60", Offset = "0x35EFD60", VA = "0x35EFD60")]
	public UMAAssetIndexer()
	{
	}

	[Token(Token = "0x60181D3")]
	[Address(RVA = "0x35EFE54", Offset = "0x35EFE54", VA = "0x35EFE54")]
	private static Type GetAssetType(int typeIndex)
	{
		return null;
	}

	[Token(Token = "0x60181D4")]
	[Address(RVA = "0x35EFF24", Offset = "0x35EFF24", VA = "0x35EFF24")]
	private static int GetAssetTypeIndex(Type type)
	{
		return default(int);
	}

	[Token(Token = "0x60181D6")]
	[Address(RVA = "0x35F03A4", Offset = "0x35F03A4", VA = "0x35F03A4")]
	public static void Cleanup()
	{
	}

	[Token(Token = "0x60181D7")]
	[Address(RVA = "0x35F051C", Offset = "0x35F051C", VA = "0x35F051C")]
	public void ClearResourceRef()
	{
	}

	[Token(Token = "0x60181D8")]
	[Address(RVA = "0x35F0AFC", Offset = "0x35F0AFC", VA = "0x35F0AFC")]
	public Type[] GetTypes()
	{
		return null;
	}

	[Token(Token = "0x60181D9")]
	[Address(RVA = "0x35F0B88", Offset = "0x35F0B88", VA = "0x35F0B88")]
	public bool IsIndexedType(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x60181DA")]
	[Address(RVA = "0x35F0D4C", Offset = "0x35F0D4C", VA = "0x35F0D4C")]
	public bool IsAdditionalIndexedType(string QualifiedName)
	{
		return default(bool);
	}

	[Token(Token = "0x60181DB")]
	[Address(RVA = "0x35F0EE4", Offset = "0x35F0EE4", VA = "0x35F0EE4")]
	public void AddType(Type sType)
	{
	}

	[Token(Token = "0x60181DC")]
	[Address(RVA = "0x35F1124", Offset = "0x35F1124", VA = "0x35F1124")]
	public void RemoveType(Type sType)
	{
	}

	[Token(Token = "0x60181DD")]
	public AssetItem GetAssetItem<T>(string Name)
	{
		return null;
	}

	[Token(Token = "0x60181DE")]
	[Address(RVA = "0x35F13A0", Offset = "0x35F13A0", VA = "0x35F13A0")]
	private void GetEvilAssetNameAndHash(Type type, Object o, ref string assetName, int assetHash)
	{
	}

	[Token(Token = "0x60181DF")]
	public List<T> GetAllAssets<T>([Optional] string[] foldersToSearch) where T : Object
	{
		return null;
	}

	[Token(Token = "0x60181E0")]
	public T GetAsset<T>(int nameHash, [Optional] string[] foldersToSearch) where T : Object
	{
		return (T)null;
	}

	[Token(Token = "0x60181E1")]
	public T GetAsset<T>(string name, [Optional] string[] foldersToSearch) where T : Object
	{
		return (T)null;
	}

	[Token(Token = "0x60181E2")]
	[Address(RVA = "0x35F14C4", Offset = "0x35F14C4", VA = "0x35F14C4")]
	private bool AssetFolderCheck(AssetItem itemToCheck, [Optional] string[] foldersToSearch)
	{
		return default(bool);
	}

	[Token(Token = "0x60181E3")]
	[Address(RVA = "0x35F1578", Offset = "0x35F1578", VA = "0x35F1578")]
	public void AddAsset(Type type, string Name, string Path, Object o, bool SkipBundleCheck = false)
	{
	}

	[Token(Token = "0x60181E4")]
	[Address(RVA = "0x35F16D0", Offset = "0x35F16D0", VA = "0x35F16D0")]
	public void AddAssetItem(AssetItem ai, bool SkipBundleCheck = false)
	{
	}

	[Token(Token = "0x60181E5")]
	[Address(RVA = "0x35F1B94", Offset = "0x35F1B94", VA = "0x35F1B94")]
	private void UpdateDictionaries(bool SkipBundleCheck = false)
	{
	}

	[Token(Token = "0x60181E6")]
	[Address(RVA = "0x35F1DF0", Offset = "0x35F1DF0", VA = "0x35F1DF0")]
	public void CreateLookupDictionary(Type type)
	{
	}

	[Token(Token = "0x60181E7")]
	[Address(RVA = "0x35F1F04", Offset = "0x35F1F04", VA = "0x35F1F04")]
	private void UpdateList()
	{
	}

	[Token(Token = "0x60181E8")]
	[Address(RVA = "0x35F096C", Offset = "0x35F096C", VA = "0x35F096C")]
	public Dictionary<string, AssetItem> GetAssetDictionary(Type type)
	{
		return null;
	}

	[Token(Token = "0x60181E9")]
	[Address(RVA = "0x35F21D8", Offset = "0x35F21D8", VA = "0x35F21D8")]
	public void RebuildIndex()
	{
	}

	[Token(Token = "0x60181EA")]
	[Address(RVA = "0x35F24AC", Offset = "0x35F24AC", VA = "0x35F24AC")]
	public UMAMeshData GetBaseBoneData(bool isMale)
	{
		return null;
	}

	[Token(Token = "0x60181EB")]
	[Address(RVA = "0x35F25C0", Offset = "0x35F25C0", VA = "0x35F25C0", Slot = "4")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[Token(Token = "0x60181EC")]
	[Address(RVA = "0x35F25C4", Offset = "0x35F25C4", VA = "0x35F25C4", Slot = "5")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}
}
