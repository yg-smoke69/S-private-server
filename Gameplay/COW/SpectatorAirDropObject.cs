using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A96")]
public class SpectatorAirDropObject : MonoBehaviour
{
	[Token(Token = "0x4018E9B")]
	private const uint AIRDROP_COLOR_ACTIVE = 4290380031u;

	[Token(Token = "0x4018E9C")]
	private const uint AIRDROP_COLOR_DISACTIVE = 2812782591u;

	[Token(Token = "0x4018E9D")]
	[FieldOffset(Offset = "0xC")]
	public UISprite AirDropSprite;

	[Token(Token = "0x4018E9E")]
	[FieldOffset(Offset = "0x10")]
	public UILabel IndexLadel;

	[Token(Token = "0x4018E9F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton GotoBtn;

	[Token(Token = "0x4018EA0")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 m_Pos;

	[Token(Token = "0x4018EA1")]
	[FieldOffset(Offset = "0x24")]
	private int m_Index;

	[Token(Token = "0x4018EA2")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsActive;

	[Token(Token = "0x170016D7")]
	public bool Active
	{
		[Token(Token = "0x601736D")]
		[Address(RVA = "0x288D74C", Offset = "0x288D74C", VA = "0x288D74C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601736C")]
		[Address(RVA = "0x288D5F4", Offset = "0x288D5F4", VA = "0x288D5F4")]
		set
		{
		}
	}

	[Token(Token = "0x170016D8")]
	public Vector3 Scale
	{
		[Token(Token = "0x601736F")]
		[Address(RVA = "0x288D858", Offset = "0x288D858", VA = "0x288D858")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x601736E")]
		[Address(RVA = "0x288D7A4", Offset = "0x288D7A4", VA = "0x288D7A4")]
		set
		{
		}
	}

	[Token(Token = "0x170016D9")]
	public Vector3 Position
	{
		[Token(Token = "0x6017371")]
		[Address(RVA = "0x288D99C", Offset = "0x288D99C", VA = "0x288D99C")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x6017370")]
		[Address(RVA = "0x288D8E8", Offset = "0x288D8E8", VA = "0x288D8E8")]
		set
		{
		}
	}

	[Token(Token = "0x601736B")]
	[Address(RVA = "0x288D5EC", Offset = "0x288D5EC", VA = "0x288D5EC")]
	public SpectatorAirDropObject()
	{
	}

	[Token(Token = "0x6017372")]
	[Address(RVA = "0x288DA2C", Offset = "0x288DA2C", VA = "0x288DA2C")]
	public void SetIndex(int index)
	{
	}

	[Token(Token = "0x6017373")]
	[Address(RVA = "0x288DB58", Offset = "0x288DB58", VA = "0x288DB58")]
	public void SetPostion(Vector3 pos)
	{
	}

	[Token(Token = "0x6017374")]
	[Address(RVA = "0x288DCA8", Offset = "0x288DCA8", VA = "0x288DCA8")]
	private void OnGotoClick()
	{
	}
}
