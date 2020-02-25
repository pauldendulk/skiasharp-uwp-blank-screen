# skiasharp-uwp-blank-screen

Minimal repoduction of possible skiasharp bug using skiasharp 1.68.2-preview.29.

### Versions tested
- ❌ 1.68.2-preview.29
- ❌ 1.68.1.1 (latest stable)
- ❌ 1.68.1
- ✔️ 1.68.0

### Reproduce:
- Run app
- You will see a pink rectangle.
- Click 'click me' at the bottom.
- You will see 'This is the second form. Now go back'.
- Press back button at top left.
- You will see a blank screen.

### Expected:
- Downgrade to skiasharp 1.68.0
- Do as a above
- You will still see the pink rectangle in the last step.
