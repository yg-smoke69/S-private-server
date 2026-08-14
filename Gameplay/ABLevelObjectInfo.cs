using System.IO;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D2F")]
public abstract class ABLevelObjectInfo
{
	[Token(Token = "0x4019F1D")]
	[FieldOffset(Offset = "0x8")]
	public int GoInfoIndex;

	[Token(Token = "0x6018795")]
	[Address(RVA = "0x35BB99C", Offset = "0x35BB99C", VA = "0x35BB99C")]
	protected ABLevelObjectInfo()
	{
	}

	[Token(Token = "0x6018796")]
	[Address(RVA = "0x35BB9A4", Offset = "0x35BB9A4", VA = "0x35BB9A4")]
	public static ABLevelObjectInfo CreateInfoDataByType(EABLevelObjectInfoType type)
	{
		return null;
	}

	[Token(Token = "0x6018797")]
	public abstract EABLevelObjectInfoType GetABLevelObjectInfoType();

	[Token(Token = "0x6018798")]
	[Address(RVA = "0x35BBA4C", Offset = "0x35BBA4C", VA = "0x35BBA4C")]
	public void SerializedData(ref BinaryWriter writer)
	{
	}

	[Token(Token = "0x6018799")]
	[Address(RVA = "0x35BBAA8", Offset = "0x35BBAA8", VA = "0x35BBAA8")]
	public void UnSerializedData(ref BinaryReader reader)
	{
	}

	[Token(Token = "0x601879A")]
	protected abstract void OnSerializedData(ref BinaryWriter writer);

	[Token(Token = "0x601879B")]
	protected abstract void OnUnSerializedData(ref BinaryReader reader);

	[Token(Token = "0x601879C")]
	public abstract void ApplyData(GameObject inst_object);

	[Token(Token = "0x601879D")]
	public abstract bool CreateInfo(GameObject level_object);
}
