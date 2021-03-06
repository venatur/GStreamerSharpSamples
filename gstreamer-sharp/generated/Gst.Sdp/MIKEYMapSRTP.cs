// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Sdp {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct MIKEYMapSRTP : IEquatable<MIKEYMapSRTP> {

		public byte Policy;
		public uint Ssrc;
		public uint Roc;

		public static Gst.Sdp.MIKEYMapSRTP Zero = new Gst.Sdp.MIKEYMapSRTP ();

		public static Gst.Sdp.MIKEYMapSRTP New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Sdp.MIKEYMapSRTP.Zero;
			return (Gst.Sdp.MIKEYMapSRTP) Marshal.PtrToStructure (raw, typeof (Gst.Sdp.MIKEYMapSRTP));
		}

		public bool Equals (MIKEYMapSRTP other)
		{
			return true && Policy.Equals (other.Policy) && Ssrc.Equals (other.Ssrc) && Roc.Equals (other.Roc);
		}

		public override bool Equals (object other)
		{
			return other is MIKEYMapSRTP && Equals ((MIKEYMapSRTP) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Policy.GetHashCode () ^ Ssrc.GetHashCode () ^ Roc.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
