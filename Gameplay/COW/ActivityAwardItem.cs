using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001E7F")]
public class ActivityAwardItem : MonoBehaviour
{
	[Token(Token = "0x2001E80")]
	private class ScaleKey
	{
		[Token(Token = "0x400BFDF")]
		[FieldOffset(Offset = "0x8")]
		public CSSharedItemDataManager.ItemType itemType;

		[Token(Token = "0x400BFE0")]
		[FieldOffset(Offset = "0xC")]
		public uint subType;

		[Token(Token = "0x60092C6")]
		[Address(RVA = "0x14BC00C", Offset = "0x14BC00C", VA = "0x14BC00C")]
		public ScaleKey(CSSharedItemDataManager.ItemType itemType, uint subType)
		{
		}
	}

	[Token(Token = "0x2001E81")]
	private class ScaleKeyCompare : _Attribute
	{
		[Token(Token = "0x60092C7")]
		[Address(RVA = "0x14BC004", Offset = "0x14BC004", VA = "0x14BC004")]
		public ScaleKeyCompare()
		{
		}

		[Token(Token = "0x60092C8")]
		[Address(RVA = "0x14BE1CC", Offset = "0x14BE1CC", VA = "0x14BE1CC", Slot = "4")]
		private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CCOW_002EActivityAwardItem_002EScaleKey_003E_002EEquals(ScaleKey x, ScaleKey y)
		{
			return default(bool);
		}

		[Token(Token = "0x60092C9")]
		[Address(RVA = "0x14BE288", Offset = "0x14BE288", VA = "0x14BE288", Slot = "5")]
		private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CCOW_002EActivityAwardItem_002EScaleKey_003E_002EGetHashCode(ScaleKey obj)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400BFB6")]
	[FieldOffset(Offset = "0xC")]
	public UILabel Limitation;

	[Token(Token = "0x400BFB7")]
	[FieldOffset(Offset = "0x10")]
	public UILabel Count;

	[Token(Token = "0x400BFB8")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Icon;

	[Token(Token = "0x400BFB9")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x400BFBA")]
	[FieldOffset(Offset = "0x1C")]
	public bool ShowOwnCount;

	[Token(Token = "0x400BFBB")]
	[FieldOffset(Offset = "0x20")]
	public List<UIWidget> Quality;

	[Token(Token = "0x400BFBC")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 ScaleTreasureBox;

	[Token(Token = "0x400BFBD")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 ScaleProps;

	[Token(Token = "0x400BFBE")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 ScaleRoomCard;

	[Token(Token = "0x400BFBF")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 ScaleDebris;

	[Token(Token = "0x400BFC0")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 ScaleVirtualGoods;

	[Token(Token = "0x400BFC1")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 ScaleAvatar;

	[Token(Token = "0x400BFC2")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 ScaleBundle;

	[Token(Token = "0x400BFC3")]
	[FieldOffset(Offset = "0x5C")]
	public Vector2 ScaleOptionalBundle;

	[Token(Token = "0x400BFC4")]
	[FieldOffset(Offset = "0x64")]
	public Vector2 ScaleCloth;

	[Token(Token = "0x400BFC5")]
	[FieldOffset(Offset = "0x6C")]
	public Vector2 ScaleBonusCard;

	[Token(Token = "0x400BFC6")]
	[FieldOffset(Offset = "0x74")]
	public Vector2 ScaleBackpack;

	[Token(Token = "0x400BFC7")]
	[FieldOffset(Offset = "0x7C")]
	public Vector2 ScaleBanner;

	[Token(Token = "0x400BFC8")]
	[FieldOffset(Offset = "0x84")]
	public Vector2 ScaleHeadPic;

	[Token(Token = "0x400BFC9")]
	[FieldOffset(Offset = "0x8C")]
	public Vector2 ScaleLootBox;

	[Token(Token = "0x400BFCA")]
	[FieldOffset(Offset = "0x94")]
	public Vector2 ScaleParachute;

	[Token(Token = "0x400BFCB")]
	[FieldOffset(Offset = "0x9C")]
	public Vector2 ScaleSkyboard;

	[Token(Token = "0x400BFCC")]
	[FieldOffset(Offset = "0xA4")]
	public Vector2 ScaleFlight;

	[Token(Token = "0x400BFCD")]
	[FieldOffset(Offset = "0xAC")]
	public Vector2 ScaleWeapon;

	[Token(Token = "0x400BFCE")]
	[FieldOffset(Offset = "0xB4")]
	public Vector2 ScaleGrenade;

	[Token(Token = "0x400BFCF")]
	[FieldOffset(Offset = "0xBC")]
	public Vector2 ScaleVehicle;

	[Token(Token = "0x400BFD0")]
	[FieldOffset(Offset = "0xC4")]
	public Vector2 ScaleEmote;

	[Token(Token = "0x400BFD1")]
	[FieldOffset(Offset = "0xCC")]
	public float RotateWeapon;

	[Token(Token = "0x400BFD2")]
	[FieldOffset(Offset = "0xD0")]
	public bool UseDefaultColor;

	[Token(Token = "0x400BFD3")]
	[FieldOffset(Offset = "0xD4")]
	public Vector2 CurrentUseScale;

	[Token(Token = "0x400BFD4")]
	[FieldOffset(Offset = "0xDC")]
	private UILabel m_ValueLabel;

	[Token(Token = "0x400BFD5")]
	[FieldOffset(Offset = "0xE0")]
	private BoxCollider m_BoxCollider;

	[Token(Token = "0x400BFD6")]
	[FieldOffset(Offset = "0xE4")]
	private UIEventListener m_Listener;

	[Token(Token = "0x400BFD7")]
	[FieldOffset(Offset = "0xE8")]
	public int m_OriHeight;

	[Token(Token = "0x400BFD8")]
	[FieldOffset(Offset = "0xEC")]
	public int m_OriWidth;

	[Token(Token = "0x400BFD9")]
	[FieldOffset(Offset = "0xF0")]
	public int m_Ori_BgWidth;

	[Token(Token = "0x400BFDA")]
	[FieldOffset(Offset = "0xF4")]
	private Dictionary<ScaleKey, Vector2> m_ScaleMap;

	[Token(Token = "0x400BFDB")]
	[FieldOffset(Offset = "0xF8")]
	private int m_BGPaddingX;

	[Token(Token = "0x400BFDC")]
	[FieldOffset(Offset = "0xFC")]
	private BaseItemInfo m_Data;

	[Token(Token = "0x400BFDD")]
	[FieldOffset(Offset = "0x100")]
	private CSSharedItemData m_ItemData;

	[Token(Token = "0x400BFDE")]
	[FieldOffset(Offset = "0x104")]
	private int _003CTargetBGWidth_003Ek__BackingField;

	[Token(Token = "0x17000F36")]
	public int TargetBGWidth
	{
		[Token(Token = "0x60092B9")]
		[Address(RVA = "0x14BC03C", Offset = "0x14BC03C", VA = "0x14BC03C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60092B8")]
		[Address(RVA = "0x14BC034", Offset = "0x14BC034", VA = "0x14BC034")]
		private set
		{
		}
	}

	[Token(Token = "0x60092B3")]
	[Address(RVA = "0x14BB088", Offset = "0x14BB088", VA = "0x14BB088")]
	public ActivityAwardItem()
	{
	}

	[Token(Token = "0x60092B4")]
	[Address(RVA = "0x14BB470", Offset = "0x14BB470", VA = "0x14BB470")]
	private void Awake()
	{
	}

	[Token(Token = "0x60092B5")]
	[Address(RVA = "0x14BB54C", Offset = "0x14BB54C", VA = "0x14BB54C")]
	private void Start()
	{
	}

	[Token(Token = "0x60092B6")]
	[Address(RVA = "0x14BB5A0", Offset = "0x14BB5A0", VA = "0x14BB5A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60092B7")]
	[Address(RVA = "0x14BB5F4", Offset = "0x14BB5F4", VA = "0x14BB5F4")]
	private void InitScaleMap()
	{
	}

	[Token(Token = "0x60092BA")]
	[Address(RVA = "0x14BC044", Offset = "0x14BC044", VA = "0x14BC044")]
	public void SetData(BaseItemInfo data)
	{
	}

	[Token(Token = "0x60092BB")]
	[Address(RVA = "0x14BDC5C", Offset = "0x14BDC5C", VA = "0x14BDC5C")]
	public void UpdateCount()
	{
	}

	[Token(Token = "0x60092BC")]
	[Address(RVA = "0x14BD880", Offset = "0x14BD880", VA = "0x14BD880")]
	public string CalcCount(BaseItemInfo data)
	{
		return null;
	}

	[Token(Token = "0x60092BD")]
	[Address(RVA = "0x14BDD40", Offset = "0x14BDD40", VA = "0x14BDD40")]
	public int GetWitdh()
	{
		return default(int);
	}

	[Token(Token = "0x60092BE")]
	[Address(RVA = "0x14BDDC4", Offset = "0x14BDDC4", VA = "0x14BDDC4")]
	public int GetHeight()
	{
		return default(int);
	}

	[Token(Token = "0x60092BF")]
	[Address(RVA = "0x14BCCD8", Offset = "0x14BCCD8", VA = "0x14BCCD8")]
	private Vector2 GetIconScale(BaseItemInfo item)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x60092C0")]
	[Address(RVA = "0x14BCEDC", Offset = "0x14BCEDC", VA = "0x14BCEDC")]
	private float GetIconRotate(BaseItemInfo item)
	{
		return default(float);
	}

	[Token(Token = "0x60092C1")]
	[Address(RVA = "0x14BDE3C", Offset = "0x14BDE3C", VA = "0x14BDE3C")]
	private bool GetIconSpecialScale(CSSharedItemData itemData, out Vector2 scale)
	{
		return default(bool);
	}

	[Token(Token = "0x60092C2")]
	[Address(RVA = "0x14BDF18", Offset = "0x14BDF18", VA = "0x14BDF18")]
	private bool IsGrenade(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60092C3")]
	[Address(RVA = "0x14BD2AC", Offset = "0x14BD2AC", VA = "0x14BD2AC")]
	private void AttachSpecialUI()
	{
	}

	[Token(Token = "0x60092C4")]
	[Address(RVA = "0x14BCF88", Offset = "0x14BCF88", VA = "0x14BCF88")]
	private void AttachBoxCollider()
	{
	}

	[Token(Token = "0x60092C5")]
	[Address(RVA = "0x14BE0AC", Offset = "0x14BE0AC", VA = "0x14BE0AC")]
	private void _003CAttachBoxCollider_003Em__0(GameObject e)
	{
	}
}
