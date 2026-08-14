using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput;

[Token(Token = "0x2003B18")]
public static class CrossPlatformInputManager
{
	[Token(Token = "0x2003B19")]
	public enum ActiveInputMethod
	{
		[Token(Token = "0x4019294")]
		Hardware,
		[Token(Token = "0x4019295")]
		Touch
	}

	[Token(Token = "0x2003B1A")]
	public class VirtualAxis
	{
		[Token(Token = "0x4019296")]
		[FieldOffset(Offset = "0x8")]
		private string _003Cname_003Ek__BackingField;

		[Token(Token = "0x4019297")]
		[FieldOffset(Offset = "0xC")]
		private float m_Value;

		[Token(Token = "0x4019298")]
		[FieldOffset(Offset = "0x10")]
		private bool _003CmatchWithInputManager_003Ek__BackingField;

		[Token(Token = "0x170017C9")]
		public string name
		{
			[Token(Token = "0x6017758")]
			[Address(RVA = "0x2A65654", Offset = "0x2A65654", VA = "0x2A65654")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017759")]
			[Address(RVA = "0x2A65644", Offset = "0x2A65644", VA = "0x2A65644")]
			private set
			{
			}
		}

		[Token(Token = "0x170017CA")]
		public bool matchWithInputManager
		{
			[Token(Token = "0x601775A")]
			[Address(RVA = "0x2A6565C", Offset = "0x2A6565C", VA = "0x2A6565C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601775B")]
			[Address(RVA = "0x2A6564C", Offset = "0x2A6564C", VA = "0x2A6564C")]
			private set
			{
			}
		}

		[Token(Token = "0x170017CB")]
		public float GetValue
		{
			[Token(Token = "0x601775E")]
			[Address(RVA = "0x2A656F0", Offset = "0x2A656F0", VA = "0x2A656F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170017CC")]
		public float GetValueRaw
		{
			[Token(Token = "0x601775F")]
			[Address(RVA = "0x2A656F8", Offset = "0x2A656F8", VA = "0x2A656F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6017756")]
		[Address(RVA = "0x2A655F4", Offset = "0x2A655F4", VA = "0x2A655F4")]
		public VirtualAxis(string name)
		{
		}

		[Token(Token = "0x6017757")]
		[Address(RVA = "0x2A6561C", Offset = "0x2A6561C", VA = "0x2A6561C")]
		public VirtualAxis(string name, bool matchToInputSettings)
		{
		}

		[Token(Token = "0x601775C")]
		[Address(RVA = "0x2A65664", Offset = "0x2A65664", VA = "0x2A65664")]
		public void Remove()
		{
		}

		[Token(Token = "0x601775D")]
		[Address(RVA = "0x2A656E8", Offset = "0x2A656E8", VA = "0x2A656E8")]
		public void Update(float value)
		{
		}
	}

	[Token(Token = "0x2003B1B")]
	public class VirtualButton
	{
		[Token(Token = "0x4019299")]
		[FieldOffset(Offset = "0x8")]
		private string _003Cname_003Ek__BackingField;

		[Token(Token = "0x401929A")]
		[FieldOffset(Offset = "0xC")]
		private bool _003CmatchWithInputManager_003Ek__BackingField;

		[Token(Token = "0x401929B")]
		[FieldOffset(Offset = "0x10")]
		private int m_LastPressedFrame;

		[Token(Token = "0x401929C")]
		[FieldOffset(Offset = "0x14")]
		private int m_ReleasedFrame;

		[Token(Token = "0x401929D")]
		[FieldOffset(Offset = "0x18")]
		private bool m_Pressed;

		[Token(Token = "0x170017CD")]
		public string name
		{
			[Token(Token = "0x6017762")]
			[Address(RVA = "0x2A65780", Offset = "0x2A65780", VA = "0x2A65780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017763")]
			[Address(RVA = "0x2A65770", Offset = "0x2A65770", VA = "0x2A65770")]
			private set
			{
			}
		}

		[Token(Token = "0x170017CE")]
		public bool matchWithInputManager
		{
			[Token(Token = "0x6017764")]
			[Address(RVA = "0x2A65788", Offset = "0x2A65788", VA = "0x2A65788")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017765")]
			[Address(RVA = "0x2A65778", Offset = "0x2A65778", VA = "0x2A65778")]
			private set
			{
			}
		}

		[Token(Token = "0x170017CF")]
		public bool GetButton
		{
			[Token(Token = "0x6017769")]
			[Address(RVA = "0x2A65868", Offset = "0x2A65868", VA = "0x2A65868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170017D0")]
		public bool GetButtonDown
		{
			[Token(Token = "0x601776A")]
			[Address(RVA = "0x2A65870", Offset = "0x2A65870", VA = "0x2A65870")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170017D1")]
		public bool GetButtonUp
		{
			[Token(Token = "0x601776B")]
			[Address(RVA = "0x2A6589C", Offset = "0x2A6589C", VA = "0x2A6589C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6017760")]
		[Address(RVA = "0x2A65700", Offset = "0x2A65700", VA = "0x2A65700")]
		public VirtualButton(string name)
		{
		}

		[Token(Token = "0x6017761")]
		[Address(RVA = "0x2A65738", Offset = "0x2A65738", VA = "0x2A65738")]
		public VirtualButton(string name, bool matchToInputSettings)
		{
		}

		[Token(Token = "0x6017766")]
		[Address(RVA = "0x2A65790", Offset = "0x2A65790", VA = "0x2A65790")]
		public void Pressed()
		{
		}

		[Token(Token = "0x6017767")]
		[Address(RVA = "0x2A657C0", Offset = "0x2A657C0", VA = "0x2A657C0")]
		public void Released()
		{
		}

		[Token(Token = "0x6017768")]
		[Address(RVA = "0x2A657E4", Offset = "0x2A657E4", VA = "0x2A657E4")]
		public void Remove()
		{
		}
	}

	[Token(Token = "0x4019290")]
	[FieldOffset(Offset = "0x0")]
	private static VirtualInput activeInput;

	[Token(Token = "0x4019291")]
	[FieldOffset(Offset = "0x4")]
	private static VirtualInput s_TouchInput;

	[Token(Token = "0x4019292")]
	[FieldOffset(Offset = "0x8")]
	private static VirtualInput s_HardwareInput;

	[Token(Token = "0x170017C8")]
	public static Vector3 mousePosition
	{
		[Token(Token = "0x6017752")]
		[Address(RVA = "0x2A651B0", Offset = "0x2A651B0", VA = "0x2A651B0")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x601773C")]
	[Address(RVA = "0x2A63EFC", Offset = "0x2A63EFC", VA = "0x2A63EFC")]
	static CrossPlatformInputManager()
	{
	}

	[Token(Token = "0x601773D")]
	[Address(RVA = "0x2A63FB4", Offset = "0x2A63FB4", VA = "0x2A63FB4")]
	public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
	{
	}

	[Token(Token = "0x601773E")]
	[Address(RVA = "0x2A640A4", Offset = "0x2A640A4", VA = "0x2A640A4")]
	public static bool AxisExists(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x601773F")]
	[Address(RVA = "0x2A641D0", Offset = "0x2A641D0", VA = "0x2A641D0")]
	public static bool ButtonExists(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6017740")]
	[Address(RVA = "0x2A642FC", Offset = "0x2A642FC", VA = "0x2A642FC")]
	public static void RegisterVirtualAxis(VirtualAxis axis)
	{
	}

	[Token(Token = "0x6017741")]
	[Address(RVA = "0x2A64558", Offset = "0x2A64558", VA = "0x2A64558")]
	public static void RegisterVirtualButton(VirtualButton button)
	{
	}

	[Token(Token = "0x6017742")]
	[Address(RVA = "0x2A647B4", Offset = "0x2A647B4", VA = "0x2A647B4")]
	public static void UnRegisterVirtualAxis(string name)
	{
	}

	[Token(Token = "0x6017743")]
	[Address(RVA = "0x2A64978", Offset = "0x2A64978", VA = "0x2A64978")]
	public static void UnRegisterVirtualButton(string name)
	{
	}

	[Token(Token = "0x6017744")]
	[Address(RVA = "0x2A64ADC", Offset = "0x2A64ADC", VA = "0x2A64ADC")]
	public static VirtualAxis VirtualAxisReference(string name)
	{
		return null;
	}

	[Token(Token = "0x6017745")]
	[Address(RVA = "0x2A64C48", Offset = "0x2A64C48", VA = "0x2A64C48")]
	public static float GetAxis(string name)
	{
		return default(float);
	}

	[Token(Token = "0x6017746")]
	[Address(RVA = "0x2A64D8C", Offset = "0x2A64D8C", VA = "0x2A64D8C")]
	public static float GetAxisRaw(string name)
	{
		return default(float);
	}

	[Token(Token = "0x6017747")]
	[Address(RVA = "0x2A64CCC", Offset = "0x2A64CCC", VA = "0x2A64CCC")]
	private static float GetAxis(string name, bool raw)
	{
		return default(float);
	}

	[Token(Token = "0x6017748")]
	[Address(RVA = "0x2A64E10", Offset = "0x2A64E10", VA = "0x2A64E10")]
	public static bool GetButton(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6017749")]
	[Address(RVA = "0x2A64EC8", Offset = "0x2A64EC8", VA = "0x2A64EC8")]
	public static bool GetButtonDown(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x601774A")]
	[Address(RVA = "0x2A64F80", Offset = "0x2A64F80", VA = "0x2A64F80")]
	public static bool GetButtonUp(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x601774B")]
	[Address(RVA = "0x2A63950", Offset = "0x2A63950", VA = "0x2A63950")]
	public static void SetButtonDown(string name)
	{
	}

	[Token(Token = "0x601774C")]
	[Address(RVA = "0x2A63A8C", Offset = "0x2A63A8C", VA = "0x2A63A8C")]
	public static void SetButtonUp(string name)
	{
	}

	[Token(Token = "0x601774D")]
	[Address(RVA = "0x2A65038", Offset = "0x2A65038", VA = "0x2A65038")]
	public static bool GetKeyCodeButton(KeyCode kc)
	{
		return default(bool);
	}

	[Token(Token = "0x601774E")]
	[Address(RVA = "0x2A63BC8", Offset = "0x2A63BC8", VA = "0x2A63BC8")]
	public static void SetAxisPositive(string name)
	{
	}

	[Token(Token = "0x601774F")]
	[Address(RVA = "0x2A63E40", Offset = "0x2A63E40", VA = "0x2A63E40")]
	public static void SetAxisNegative(string name)
	{
	}

	[Token(Token = "0x6017750")]
	[Address(RVA = "0x2A63D04", Offset = "0x2A63D04", VA = "0x2A63D04")]
	public static void SetAxisZero(string name)
	{
	}

	[Token(Token = "0x6017751")]
	[Address(RVA = "0x2A650F0", Offset = "0x2A650F0", VA = "0x2A650F0")]
	public static void SetAxis(string name, float value)
	{
	}

	[Token(Token = "0x6017753")]
	[Address(RVA = "0x2A65268", Offset = "0x2A65268", VA = "0x2A65268")]
	public static void SetVirtualMousePositionX(float f)
	{
	}

	[Token(Token = "0x6017754")]
	[Address(RVA = "0x2A65394", Offset = "0x2A65394", VA = "0x2A65394")]
	public static void SetVirtualMousePositionY(float f)
	{
	}

	[Token(Token = "0x6017755")]
	[Address(RVA = "0x2A654C4", Offset = "0x2A654C4", VA = "0x2A654C4")]
	public static void SetVirtualMousePositionZ(float f)
	{
	}
}
