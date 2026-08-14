using ECAPackage;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BA9")]
public static class ValueTypeUtil
{
	[Token(Token = "0x2000BAA")]
	private sealed class _003CGetPropertyValueType_003Ec__AnonStorey0
	{
		[Token(Token = "0x4006229")]
		[FieldOffset(Offset = "0x8")]
		internal int propertyIntVal;

		[Token(Token = "0x600585B")]
		[Address(RVA = "0x2F54F1C", Offset = "0x2F54F1C", VA = "0x2F54F1C")]
		public _003CGetPropertyValueType_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600585C")]
		[Address(RVA = "0x2F54FF8", Offset = "0x2F54FF8", VA = "0x2F54FF8")]
		internal bool _003C_003Em__0(ECADefineBase e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600584F")]
	[Address(RVA = "0x2F54640", Offset = "0x2F54640", VA = "0x2F54640")]
	public static bool CheckLegalityBefore(TypeInfo blockType, TypeInfo slotType)
	{
		return default(bool);
	}

	[Token(Token = "0x6005850")]
	[Address(RVA = "0x2F54428", Offset = "0x2F54428", VA = "0x2F54428")]
	internal static bool CheckLegalityWhiteList(TypeInfo blockType, TypeInfo slotType)
	{
		return default(bool);
	}

	[Token(Token = "0x6005851")]
	[Address(RVA = "0x2F54734", Offset = "0x2F54734", VA = "0x2F54734")]
	public static bool IsEntity(IOGCEGJJHLK valueType)
	{
		return default(bool);
	}

	[Token(Token = "0x6005852")]
	[Address(RVA = "0x2F54854", Offset = "0x2F54854", VA = "0x2F54854")]
	public static NKLPCICJPND CastCompareType(int compareType)
	{
		return default(NKLPCICJPND);
	}

	[Token(Token = "0x6005853")]
	[Address(RVA = "0x2F548E8", Offset = "0x2F548E8", VA = "0x2F548E8")]
	public static bool IsComparable(NKLPCICJPND compareType, ValueData left, ValueData right)
	{
		return default(bool);
	}

	[Token(Token = "0x6005854")]
	[Address(RVA = "0x2F54B10", Offset = "0x2F54B10", VA = "0x2F54B10")]
	public static void UpdateComparerFormalTypes(NKLPCICJPND compareType, ValueData left, ValueData right)
	{
	}

	[Token(Token = "0x6005855")]
	[Address(RVA = "0x2F532DC", Offset = "0x2F532DC", VA = "0x2F532DC")]
	public static OHAAMABDKEN CastConstSaveType(IOGCEGJJHLK type)
	{
		return default(OHAAMABDKEN);
	}

	[Token(Token = "0x6005856")]
	[Address(RVA = "0x2F547BC", Offset = "0x2F547BC", VA = "0x2F547BC")]
	public static IOGCEGJJHLK GetArrayElementType(IOGCEGJJHLK type)
	{
		return default(IOGCEGJJHLK);
	}

	[Token(Token = "0x6005857")]
	[Address(RVA = "0x2F51110", Offset = "0x2F51110", VA = "0x2F51110")]
	public static IOGCEGJJHLK GetBaseEntityType(string entityType)
	{
		return default(IOGCEGJJHLK);
	}

	[Token(Token = "0x6005858")]
	[Address(RVA = "0x2F54C48", Offset = "0x2F54C48", VA = "0x2F54C48")]
	public static IOGCEGJJHLK GetPropertyValueType(string entityType, int propertyIntVal, bool excludeReadOnly)
	{
		return default(IOGCEGJJHLK);
	}

	[Token(Token = "0x6005859")]
	[Address(RVA = "0x2F4CB30", Offset = "0x2F4CB30", VA = "0x2F4CB30")]
	public static TypeInfo GetTypeInfo(string typeString)
	{
		return default(TypeInfo);
	}

	[Token(Token = "0x600585A")]
	[Address(RVA = "0x2F54F24", Offset = "0x2F54F24", VA = "0x2F54F24")]
	public static IOGCEGJJHLK GetNumberValueType(ValueData value)
	{
		return default(IOGCEGJJHLK);
	}
}
