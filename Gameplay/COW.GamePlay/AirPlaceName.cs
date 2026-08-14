using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20007A4")]
public class AirPlaceName : Entity
{
	[Token(Token = "0x20007A5")]
	public class KPGIGHAHMPG : CSVBaseData
	{
		[Token(Token = "0x4004EF5")]
		[FieldOffset(Offset = "0x8")]
		public int IDNEFEOPGIF;

		[Token(Token = "0x4004EF6")]
		[FieldOffset(Offset = "0xC")]
		public ResourceID MFMJGCGJBCJ;

		[Token(Token = "0x60030B6")]
		[Address(RVA = "0x1137244", Offset = "0x1137244", VA = "0x1137244")]
		public KPGIGHAHMPG()
		{
		}

		[Token(Token = "0x60030B7")]
		[Address(RVA = "0x11372C8", Offset = "0x11372C8", VA = "0x11372C8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		[Token(Token = "0x60030B8")]
		[Address(RVA = "0x113732C", Offset = "0x113732C", VA = "0x113732C", Slot = "4")]
		public override void ParseData(long HHLONFLCJBL, int KHCPMMPFLJC, string[] HBKMAMHJAIK, string[] LEDOBKGBDAJ)
		{
		}
	}

	[Token(Token = "0x20007A6")]
	public class BGLBDKECPOI : CSVBaseData
	{
		[Token(Token = "0x4004EF7")]
		[FieldOffset(Offset = "0x8")]
		public string IDNEFEOPGIF;

		[Token(Token = "0x4004EF8")]
		[FieldOffset(Offset = "0xC")]
		public string IMDEPOFKEIL;

		[Token(Token = "0x4004EF9")]
		[FieldOffset(Offset = "0x10")]
		public float JDMGGBLNPLE;

		[Token(Token = "0x4004EFA")]
		[FieldOffset(Offset = "0x14")]
		public float PBNIFGEKHPG;

		[Token(Token = "0x4004EFB")]
		[FieldOffset(Offset = "0x18")]
		public float FDGJLLPDPLA;

		[Token(Token = "0x60030B9")]
		[Address(RVA = "0x1136EBC", Offset = "0x1136EBC", VA = "0x1136EBC")]
		public BGLBDKECPOI()
		{
		}

		[Token(Token = "0x60030BA")]
		[Address(RVA = "0x1136F40", Offset = "0x1136F40", VA = "0x1136F40", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		[Token(Token = "0x60030BB")]
		[Address(RVA = "0x1136F98", Offset = "0x1136F98", VA = "0x1136F98", Slot = "4")]
		public override void ParseData(long HHLONFLCJBL, int KHCPMMPFLJC, string[] HBKMAMHJAIK, string[] LEDOBKGBDAJ)
		{
		}
	}

	[Token(Token = "0x4004EF1")]
	[FieldOffset(Offset = "0x34")]
	public GameObject m_UIRoot;

	[Token(Token = "0x4004EF2")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_placeName;

	[Token(Token = "0x4004EF3")]
	[FieldOffset(Offset = "0x3C")]
	public List<UILabel> m_placeNameLabels;

	[Token(Token = "0x4004EF4")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<KPGIGHAHMPG> HMDOHFBHDOB;

	[Token(Token = "0x60030B1")]
	[Address(RVA = "0x1135F6C", Offset = "0x1135F6C", VA = "0x1135F6C")]
	public AirPlaceName()
	{
	}

	[Token(Token = "0x60030B2")]
	[Address(RVA = "0x1136024", Offset = "0x1136024", VA = "0x1136024")]
	public void InitPlaceName(Vector3 EBIJHALKJEM)
	{
	}

	[Token(Token = "0x60030B3")]
	[Address(RVA = "0x1136780", Offset = "0x1136780", VA = "0x1136780", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60030B4")]
	[Address(RVA = "0x1136E08", Offset = "0x1136E08", VA = "0x1136E08")]
	private static bool MFPIABFHCEG(KPGIGHAHMPG HGMBMICDALC)
	{
		return default(bool);
	}

	[Token(Token = "0x60030B5")]
	[Address(RVA = "0x1136EB4", Offset = "0x1136EB4", VA = "0x1136EB4")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
