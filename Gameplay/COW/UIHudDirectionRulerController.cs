using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002730")]
public class UIHudDirectionRulerController : UIBaseController
{
	[Token(Token = "0x400F1D1")]
	private const int RULER_INTERVAL = 15;

	[Token(Token = "0x400F1D2")]
	private const float RULER_LENGTH = 600f;

	[Token(Token = "0x400F1D3")]
	private const float SCALE_DIS_DELTA = 50f;

	[Token(Token = "0x400F1D4")]
	[FieldOffset(Offset = "0x28")]
	private UIHudDirectionRulerView m_View;

	[Token(Token = "0x400F1D5")]
	[FieldOffset(Offset = "0x2C")]
	private UILabel[] m_ScaleValues;

	[Token(Token = "0x400F1D6")]
	[FieldOffset(Offset = "0x30")]
	private UISprite[] m_TeamMark;

	[Token(Token = "0x400F1D7")]
	[FieldOffset(Offset = "0x34")]
	private float m_RulerPosY;

	[Token(Token = "0x400F1D8")]
	[FieldOffset(Offset = "0x38")]
	private float m_MarkPosY;

	[Token(Token = "0x400F1D9")]
	[FieldOffset(Offset = "0x3C")]
	private int m_NumScaleInternal;

	[Token(Token = "0x400F1DA")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_SinglePlayerMarkPos;

	[Token(Token = "0x400F1DB")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_SaveZonePos;

	[Token(Token = "0x400F1DC")]
	[FieldOffset(Offset = "0x58")]
	private SafeZone m_SafeZone;

	[Token(Token = "0x400F1DD")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 hideMarkPosition;

	[Token(Token = "0x400F1DE")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<int, string> m_ScaleStringDic;

	[Token(Token = "0x400F1DF")]
	[FieldOffset(Offset = "0x6C")]
	private bool isSolo;

	[Token(Token = "0x400F1E0")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<uint, GameObject> m_TreasureMarkDict;

	[Token(Token = "0x400F1E1")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<uint, Vector3> m_TreasureMarkPosDict;

	[Token(Token = "0x400F1E2")]
	[FieldOffset(Offset = "0x78")]
	private float m_ruler1PosX;

	[Token(Token = "0x400F1E3")]
	[FieldOffset(Offset = "0x7C")]
	private float m_ruler2PosX;

	[Token(Token = "0x600EE95")]
	[Address(RVA = "0x1CD3B78", Offset = "0x1CD3B78", VA = "0x1CD3B78")]
	public UIHudDirectionRulerController()
	{
	}

	[Token(Token = "0x600EE96")]
	[Address(RVA = "0x1CD3CE0", Offset = "0x1CD3CE0", VA = "0x1CD3CE0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EE97")]
	[Address(RVA = "0x1CD3D84", Offset = "0x1CD3D84", VA = "0x1CD3D84", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EE98")]
	[Address(RVA = "0x1CD4E74", Offset = "0x1CD4E74", VA = "0x1CD4E74", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EE99")]
	[Address(RVA = "0x1CD506C", Offset = "0x1CD506C", VA = "0x1CD506C")]
	private void Update()
	{
	}

	[Token(Token = "0x600EE9A")]
	[Address(RVA = "0x1CD5460", Offset = "0x1CD5460", VA = "0x1CD5460")]
	private float GetRotationAngleFromView(Player m_Player)
	{
		return default(float);
	}

	[Token(Token = "0x600EE9B")]
	[Address(RVA = "0x1CD5F94", Offset = "0x1CD5F94", VA = "0x1CD5F94")]
	private float GetFinalRulerScaleByVector3(Vector3 v)
	{
		return default(float);
	}

	[Token(Token = "0x600EE9C")]
	[Address(RVA = "0x1CD578C", Offset = "0x1CD578C", VA = "0x1CD578C")]
	private void UpdateMarkAndSaveZoneDirection(int startDirection, Player m_Player)
	{
	}

	[Token(Token = "0x600EE9D")]
	[Address(RVA = "0x1CD60F4", Offset = "0x1CD60F4", VA = "0x1CD60F4")]
	private void UpdateMarkUI(int startDirection, Vector3 markPos, Transform markSprite, Player m_Player)
	{
	}

	[Token(Token = "0x600EE9E")]
	[Address(RVA = "0x1CD65B8", Offset = "0x1CD65B8", VA = "0x1CD65B8")]
	private void OnTreasureMarked(object[] param)
	{
	}

	[Token(Token = "0x600EE9F")]
	[Address(RVA = "0x1CD6918", Offset = "0x1CD6918", VA = "0x1CD6918")]
	private void OnTreasureContainerDelete(object[] param)
	{
	}

	[Token(Token = "0x600EEA0")]
	[Address(RVA = "0x1CD6B58", Offset = "0x1CD6B58", VA = "0x1CD6B58")]
	private void OnStartMatchEndShow(object[] data)
	{
	}

	[Token(Token = "0x600EEA1")]
	[Address(RVA = "0x1CD6BC4", Offset = "0x1CD6BC4", VA = "0x1CD6BC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EEA2")]
	[Address(RVA = "0x1CD6BCC", Offset = "0x1CD6BCC", VA = "0x1CD6BCC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
