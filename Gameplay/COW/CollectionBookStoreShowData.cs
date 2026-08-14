using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000DB")]
public class CollectionBookStoreShowData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x8")]
	public uint HyperBookID;

	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID PreviewRes;

	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID AnimRes;

	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0x14")]
	private string _003CBookshelfCoverSpriteName_003Ek__BackingField;

	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0x18")]
	private ResourceID _003CBookshelfOpenRes_003Ek__BackingField;

	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0x1C")]
	private ResourceID _003CContentRes_003Ek__BackingField;

	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x20")]
	private ResourceID _003CContentDecorationNormalRes_003Ek__BackingField;

	[Token(Token = "0x4000529")]
	[FieldOffset(Offset = "0x24")]
	private ResourceID _003CContentDecorationHiddenRes_003Ek__BackingField;

	[Token(Token = "0x400052A")]
	[FieldOffset(Offset = "0x28")]
	private ResourceID _003CContentBackgroundNormalRes_003Ek__BackingField;

	[Token(Token = "0x400052B")]
	[FieldOffset(Offset = "0x2C")]
	private ResourceID _003CContentBackgroundHiddenRes_003Ek__BackingField;

	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x30")]
	private ResourceID[] _003CContentMaterialNormalResArray_003Ek__BackingField;

	[Token(Token = "0x400052D")]
	[FieldOffset(Offset = "0x34")]
	private ResourceID[] _003CContentMaterialHiddenResArray_003Ek__BackingField;

	[Token(Token = "0x400052E")]
	[FieldOffset(Offset = "0x38")]
	public bool IsAnimDelete;

	[Token(Token = "0x170000FF")]
	public string BookshelfCoverSpriteName
	{
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x172F3C8", Offset = "0x172F3C8", VA = "0x172F3C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x172F3D0", Offset = "0x172F3D0", VA = "0x172F3D0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000100")]
	public ResourceID BookshelfOpenRes
	{
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x172F3D8", Offset = "0x172F3D8", VA = "0x172F3D8")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x172F3E0", Offset = "0x172F3E0", VA = "0x172F3E0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000101")]
	public ResourceID ContentRes
	{
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x172F3E8", Offset = "0x172F3E8", VA = "0x172F3E8")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x172F3F0", Offset = "0x172F3F0", VA = "0x172F3F0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000102")]
	public ResourceID ContentDecorationNormalRes
	{
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x172F3F8", Offset = "0x172F3F8", VA = "0x172F3F8")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x172F400", Offset = "0x172F400", VA = "0x172F400")]
		private set
		{
		}
	}

	[Token(Token = "0x17000103")]
	public ResourceID ContentDecorationHiddenRes
	{
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x172F408", Offset = "0x172F408", VA = "0x172F408")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x172F410", Offset = "0x172F410", VA = "0x172F410")]
		private set
		{
		}
	}

	[Token(Token = "0x17000104")]
	public ResourceID ContentBackgroundNormalRes
	{
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x172F418", Offset = "0x172F418", VA = "0x172F418")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x172F420", Offset = "0x172F420", VA = "0x172F420")]
		private set
		{
		}
	}

	[Token(Token = "0x17000105")]
	public ResourceID ContentBackgroundHiddenRes
	{
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x172F428", Offset = "0x172F428", VA = "0x172F428")]
		get
		{
			return default(ResourceID);
		}
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x172F430", Offset = "0x172F430", VA = "0x172F430")]
		private set
		{
		}
	}

	[Token(Token = "0x17000106")]
	public ResourceID[] ContentMaterialNormalResArray
	{
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x172F438", Offset = "0x172F438", VA = "0x172F438")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x172F440", Offset = "0x172F440", VA = "0x172F440")]
		private set
		{
		}
	}

	[Token(Token = "0x17000107")]
	public ResourceID[] ContentMaterialHiddenResArray
	{
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x172F448", Offset = "0x172F448", VA = "0x172F448")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x172F450", Offset = "0x172F450", VA = "0x172F450")]
		private set
		{
		}
	}

	[Token(Token = "0x17000108")]
	public bool IsMaterialNormalResEmpty
	{
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x172F458", Offset = "0x172F458", VA = "0x172F458")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000109")]
	public bool IsMaterialHiddenResEmpty
	{
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x172F564", Offset = "0x172F564", VA = "0x172F564")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x172F2F0", Offset = "0x172F2F0", VA = "0x172F2F0")]
	public CollectionBookStoreShowData()
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x172F670", Offset = "0x172F670", VA = "0x172F670", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x172F6D4", Offset = "0x172F6D4", VA = "0x172F6D4", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x172F72C", Offset = "0x172F72C", VA = "0x172F72C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
