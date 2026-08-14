using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EDD")]
public class GridValueBase
{
	[Token(Token = "0x401A891")]
	[FieldOffset(Offset = "0x8")]
	protected Vector3 m_GridCoordinate;

	[Token(Token = "0x17001BF9")]
	public Vector3 GridCoordinate
	{
		[Token(Token = "0x601998C")]
		[Address(RVA = "0x32B82E0", Offset = "0x32B82E0", VA = "0x32B82E0")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x601998B")]
	[Address(RVA = "0x32B823C", Offset = "0x32B823C", VA = "0x32B823C")]
	public GridValueBase()
	{
	}

	[Token(Token = "0x601998D")]
	[Address(RVA = "0x32B82F4", Offset = "0x32B82F4", VA = "0x32B82F4", Slot = "4")]
	public virtual void InitGridValue(Vector3 coordinate)
	{
	}

	[Token(Token = "0x601998E")]
	[Address(RVA = "0x32B8300", Offset = "0x32B8300", VA = "0x32B8300", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x601998F")]
	[Address(RVA = "0x32B8424", Offset = "0x32B8424", VA = "0x32B8424", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
