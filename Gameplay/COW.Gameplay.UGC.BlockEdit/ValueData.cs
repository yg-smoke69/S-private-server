using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B8D")]
public class ValueData : _Attribute
{
	[Token(Token = "0x40061B3")]
	[FieldOffset(Offset = "0x8")]
	public EditorValueType EditorValueType;

	[Token(Token = "0x40061B4")]
	[FieldOffset(Offset = "0xC")]
	public TypeInfo ActualType;

	[Token(Token = "0x40061B5")]
	[FieldOffset(Offset = "0x14")]
	public TypeInfo FormalType;

	[Token(Token = "0x40061B6")]
	[FieldOffset(Offset = "0x1C")]
	private bool boolValue;

	[Token(Token = "0x40061B7")]
	[FieldOffset(Offset = "0x20")]
	private int intValue;

	[Token(Token = "0x40061B8")]
	[FieldOffset(Offset = "0x24")]
	private float floatValue;

	[Token(Token = "0x40061B9")]
	[FieldOffset(Offset = "0x28")]
	private string stringValue;

	[Token(Token = "0x40061BA")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 vector3Value;

	[Token(Token = "0x40061BB")]
	[FieldOffset(Offset = "0x38")]
	public BlockData value;

	[Token(Token = "0x40061BC")]
	[FieldOffset(Offset = "0x3C")]
	public LocalVarDefineData localVarDefineValue;

	[Token(Token = "0x40061BD")]
	[FieldOffset(Offset = "0x40")]
	public FuncDefineData funcDefineValue;

	[Token(Token = "0x40061BE")]
	[FieldOffset(Offset = "0x44")]
	public HudEventDefineData HudEventDefineData;

	[Token(Token = "0x40061BF")]
	[FieldOffset(Offset = "0x48")]
	public FuncRefValue funcRefValue;

	[Token(Token = "0x40061C0")]
	[FieldOffset(Offset = "0x4C")]
	public ArrayValue arrayValue;

	[Token(Token = "0x40061C1")]
	[FieldOffset(Offset = "0x50")]
	public BlockData Owner;

	[Token(Token = "0x40061C2")]
	[FieldOffset(Offset = "0x54")]
	public SerializeBlockFieldDefine FieldDefine;

	[Token(Token = "0x40061C3")]
	[FieldOffset(Offset = "0x58")]
	public int FieldIndex;

	[Token(Token = "0x40061C4")]
	[FieldOffset(Offset = "0x5C")]
	public GraphData Graph;

	[Token(Token = "0x40061C5")]
	[FieldOffset(Offset = "0x60")]
	public object UserRef;

	[Token(Token = "0x17000708")]
	public IOGCEGJJHLK ValueType
	{
		[Token(Token = "0x60057BF")]
		[Address(RVA = "0x2F50848", Offset = "0x2F50848", VA = "0x2F50848")]
		get
		{
			return default(IOGCEGJJHLK);
		}
		[Token(Token = "0x60057C0")]
		[Address(RVA = "0x2F5180C", Offset = "0x2F5180C", VA = "0x2F5180C")]
		set
		{
		}
	}

	[Token(Token = "0x17000709")]
	public bool BoolValue
	{
		[Token(Token = "0x60057C2")]
		[Address(RVA = "0x2F5194C", Offset = "0x2F5194C", VA = "0x2F5194C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60057C3")]
		[Address(RVA = "0x2F519A4", Offset = "0x2F519A4", VA = "0x2F519A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700070A")]
	public int IntValue
	{
		[Token(Token = "0x60057C4")]
		[Address(RVA = "0x2F50900", Offset = "0x2F50900", VA = "0x2F50900")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60057C5")]
		[Address(RVA = "0x2F51A24", Offset = "0x2F51A24", VA = "0x2F51A24")]
		set
		{
		}
	}

	[Token(Token = "0x1700070B")]
	public float FloatValue
	{
		[Token(Token = "0x60057C6")]
		[Address(RVA = "0x2F51A9C", Offset = "0x2F51A9C", VA = "0x2F51A9C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60057C7")]
		[Address(RVA = "0x2F51AF4", Offset = "0x2F51AF4", VA = "0x2F51AF4")]
		set
		{
		}
	}

	[Token(Token = "0x1700070C")]
	public string StringValue
	{
		[Token(Token = "0x60057C8")]
		[Address(RVA = "0x2F508A8", Offset = "0x2F508A8", VA = "0x2F508A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60057C9")]
		[Address(RVA = "0x2F51B74", Offset = "0x2F51B74", VA = "0x2F51B74")]
		set
		{
		}
	}

	[Token(Token = "0x1700070D")]
	public Vector3 Vector3Value
	{
		[Token(Token = "0x60057CA")]
		[Address(RVA = "0x2F51C64", Offset = "0x2F51C64", VA = "0x2F51C64")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x60057CB")]
		[Address(RVA = "0x2F51CD4", Offset = "0x2F51CD4", VA = "0x2F51CD4")]
		set
		{
		}
	}

	[Token(Token = "0x60057BE")]
	[Address(RVA = "0x2F41324", Offset = "0x2F41324", VA = "0x2F41324")]
	public ValueData()
	{
	}

	[Token(Token = "0x60057C1")]
	[Address(RVA = "0x2F51878", Offset = "0x2F51878", VA = "0x2F51878")]
	private void UpdateOwnerForValueChange()
	{
	}

	[Token(Token = "0x60057CC")]
	[Address(RVA = "0x2F413E0", Offset = "0x2F413E0", VA = "0x2F413E0")]
	public bool FromJsonData(BlockEditContext context, JsonData jsonData, BlockData owner)
	{
		return default(bool);
	}

	[Token(Token = "0x60057CD")]
	[Address(RVA = "0x2F51E04", Offset = "0x2F51E04", VA = "0x2F51E04")]
	public bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x60057CE")]
	[Address(RVA = "0x2F41878", Offset = "0x2F41878", VA = "0x2F41878")]
	public bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x60057CF")]
	[Address(RVA = "0x2F53350", Offset = "0x2F53350", VA = "0x2F53350")]
	internal void CollectLocalVarDefineRecursively()
	{
	}

	[Token(Token = "0x60057D0")]
	[Address(RVA = "0x2F42E50", Offset = "0x2F42E50", VA = "0x2F42E50")]
	internal ValueData Clone(BlockData owner, SerializeBlockFieldDefine fieldDefine, GraphData graphData)
	{
		return null;
	}

	[Token(Token = "0x60057D1")]
	[Address(RVA = "0x2F49860", Offset = "0x2F49860", VA = "0x2F49860")]
	public EGKJIDMCGML ToExportProtoData(BlockEditContext context)
	{
		return null;
	}

	[Token(Token = "0x60057D2")]
	[Address(RVA = "0x2F533BC", Offset = "0x2F533BC", VA = "0x2F533BC")]
	public bool ToExportProtoData(BlockEditContext context, EGKJIDMCGML result)
	{
		return default(bool);
	}

	[Token(Token = "0x60057D3")]
	[Address(RVA = "0x2F53BB8", Offset = "0x2F53BB8", VA = "0x2F53BB8", Slot = "4")]
	public BlockData GetOwner()
	{
		return null;
	}

	[Token(Token = "0x60057D4")]
	[Address(RVA = "0x2F53C10", Offset = "0x2F53C10", VA = "0x2F53C10", Slot = "5")]
	public BlockData GetChild(int index)
	{
		return null;
	}

	[Token(Token = "0x60057D5")]
	[Address(RVA = "0x2F53C74", Offset = "0x2F53C74", VA = "0x2F53C74", Slot = "6")]
	public int GetChildIndex(BlockData blockData)
	{
		return default(int);
	}

	[Token(Token = "0x60057D6")]
	[Address(RVA = "0x2F53CF4", Offset = "0x2F53CF4", VA = "0x2F53CF4", Slot = "7")]
	public bool AddBlockData(BlockData blockData, int index, bool doRegistering = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60057D7")]
	[Address(RVA = "0x2F53E50", Offset = "0x2F53E50", VA = "0x2F53E50", Slot = "8")]
	public bool RemoveBlockData(BlockData blockData, bool doUnregistering = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60057D8")]
	[Address(RVA = "0x2F53FAC", Offset = "0x2F53FAC", VA = "0x2F53FAC", Slot = "9")]
	public bool AddBlockData(BlockRecord record)
	{
		return default(bool);
	}

	[Token(Token = "0x60057D9")]
	[Address(RVA = "0x2F54188", Offset = "0x2F54188", VA = "0x2F54188", Slot = "10")]
	public bool RemoveBlockData(BlockRecord record)
	{
		return default(bool);
	}

	[Token(Token = "0x60057DA")]
	public void UpdateSelf<T>(UpdateType updateType, T param)
	{
	}

	[Token(Token = "0x60057DB")]
	public void UpdateSelfAndParent<T>(UpdateType updateType, T param)
	{
	}

	[Token(Token = "0x60057DC")]
	public void UpdateRecursively<T>(UpdateType updateType, T param)
	{
	}

	[Token(Token = "0x60057DD")]
	[Address(RVA = "0x2F542C4", Offset = "0x2F542C4", VA = "0x2F542C4")]
	public bool CheckLegality()
	{
		return default(bool);
	}
}
