using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004097")]
public class UDPClientMessageBase : _Attribute
{
	[Token(Token = "0x401B23D")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<Type, UDPClientMessageBase> CachedMessage;

	[Token(Token = "0x401B23E")]
	public const uint USER_MESSAGE_ID_START = 100u;

	[Token(Token = "0x401B23F")]
	[FieldOffset(Offset = "0x8")]
	private bool m_GetFromPool;

	[Token(Token = "0x17001CC5")]
	public bool GetFromPool
	{
		[Token(Token = "0x601A498")]
		[Address(RVA = "0x3243108", Offset = "0x3243108", VA = "0x3243108")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A499")]
		[Address(RVA = "0x3243110", Offset = "0x3243110", VA = "0x3243110")]
		set
		{
		}
	}

	[Token(Token = "0x601A497")]
	[Address(RVA = "0x3230F68", Offset = "0x3230F68", VA = "0x3230F68")]
	public UDPClientMessageBase()
	{
	}

	[Token(Token = "0x601A49A")]
	[Address(RVA = "0x3243118", Offset = "0x3243118", VA = "0x3243118")]
	public static UDPClientMessageBase UnSerializeMessage(FastBinaryReader reader, Type type)
	{
		return null;
	}

	[Token(Token = "0x601A49B")]
	[Address(RVA = "0x3243364", Offset = "0x3243364", VA = "0x3243364")]
	protected void WriteString(FastBinaryWriter writer, string value)
	{
	}

	[Token(Token = "0x601A49C")]
	[Address(RVA = "0x3243490", Offset = "0x3243490", VA = "0x3243490")]
	protected string ReadString(FastBinaryReader reader)
	{
		return null;
	}

	[Token(Token = "0x601A49D")]
	[Address(RVA = "0x3243580", Offset = "0x3243580", VA = "0x3243580")]
	protected sbyte ReadSByte(FastBinaryReader reader)
	{
		return default(sbyte);
	}

	[Token(Token = "0x601A49E")]
	[Address(RVA = "0x32435AC", Offset = "0x32435AC", VA = "0x32435AC")]
	protected short ReadInt16(FastBinaryReader reader)
	{
		return default(short);
	}

	[Token(Token = "0x601A49F")]
	[Address(RVA = "0x32435D8", Offset = "0x32435D8", VA = "0x32435D8")]
	protected int ReadInt32(FastBinaryReader reader)
	{
		return default(int);
	}

	[Token(Token = "0x601A4A0")]
	[Address(RVA = "0x3243604", Offset = "0x3243604", VA = "0x3243604")]
	protected long ReadInt64(FastBinaryReader reader)
	{
		return default(long);
	}

	[Token(Token = "0x601A4A1")]
	[Address(RVA = "0x3243630", Offset = "0x3243630", VA = "0x3243630")]
	protected byte ReadByte(FastBinaryReader reader)
	{
		return default(byte);
	}

	[Token(Token = "0x601A4A2")]
	[Address(RVA = "0x324365C", Offset = "0x324365C", VA = "0x324365C")]
	protected ushort ReadUInt16(FastBinaryReader reader)
	{
		return default(ushort);
	}

	[Token(Token = "0x601A4A3")]
	[Address(RVA = "0x3243688", Offset = "0x3243688", VA = "0x3243688")]
	protected uint ReadUInt32(FastBinaryReader reader)
	{
		return default(uint);
	}

	[Token(Token = "0x601A4A4")]
	[Address(RVA = "0x32436B4", Offset = "0x32436B4", VA = "0x32436B4")]
	protected ulong ReadUInt64(FastBinaryReader reader)
	{
		return default(ulong);
	}

	[Token(Token = "0x601A4A5")]
	[Address(RVA = "0x32436E0", Offset = "0x32436E0", VA = "0x32436E0")]
	protected float ReadSingle(FastBinaryReader reader)
	{
		return default(float);
	}

	[Token(Token = "0x601A4A6")]
	[Address(RVA = "0x324370C", Offset = "0x324370C", VA = "0x324370C")]
	protected bool ReadBoolean(FastBinaryReader reader)
	{
		return default(bool);
	}

	[Token(Token = "0x601A4A7")]
	[Address(RVA = "0x3243738", Offset = "0x3243738", VA = "0x3243738", Slot = "6")]
	public virtual void Serialize(FastBinaryWriter writer)
	{
	}

	[Token(Token = "0x601A4A8")]
	[Address(RVA = "0x32437D4", Offset = "0x32437D4", VA = "0x32437D4", Slot = "7")]
	public virtual void UnSerialize(FastBinaryReader reader)
	{
	}

	[Token(Token = "0x601A4A9")]
	[Address(RVA = "0x3243870", Offset = "0x3243870", VA = "0x3243870", Slot = "8")]
	public virtual bool CanCache()
	{
		return default(bool);
	}

	[Token(Token = "0x601A4AA")]
	[Address(RVA = "0x3243878", Offset = "0x3243878", VA = "0x3243878", Slot = "9")]
	public virtual void Recycle()
	{
	}
}
