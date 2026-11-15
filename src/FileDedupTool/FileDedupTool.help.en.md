# English quick reference

This page is a short English quick reference, **not a full translation** of the Chinese manual.
For the complete, up-to-date guide, switch the interface language to 中文 and open Help again.

## What this app does

- Finds duplicate files by name, size, image similarity, audio similarity, or SHA-256.
- Lets you preview every decision before anything is moved or deleted.
- Supports undo for the last task, moving files to the Recycle Bin, and keeping a log of every operation.

## Before you start

- Keep a backup of important folders.
- Run a **Scan preview** first and review the list.
- Leave **Dry run** enabled until you are satisfied with the result.

## Main window

| Area | Meaning |
| --- | --- |
| Source folder | The folder that will be scanned. |
| Target folder | Where kept files are moved or copied. |
| Steps 1–5 | Name, content, image, audio, and empty-folder checks. |
| Keep rule | Which copy is kept when duplicates are found. |
| Conflict policy | Rename, keep both, or delete on a name conflict. |
| Log | Every step is written here; use **View log** to open the file. |

## Dedup steps

1. **Step 1 – name**: groups files with the same normalized name.
2. **Step 2 – content**: compares size and SHA-256; exact duplicates are detected here.
3. **Step 3 – image**: groups visually similar pictures with a perceptual hash.
4. **Step 4 – audio**: groups similar audio files by fingerprint.
5. **Step 5 – empty folders**: optionally removes empty folders after the move.

Steps 2–4 can be enabled independently. Disabled steps are skipped, not treated as failures.

## Safety rules

- Deleted files go to the Recycle Bin by default; permanent deletion must be chosen explicitly.
- **Undo last task** restores files from the operation log and never overwrites an existing file.
- Files in use are reported; the app never terminates system processes or Explorer.
- Suspicious names (random letters, dates only, mixed case, no vowels) are flagged for review.

## Organize by date

Choose **Organize by time** to move or copy files into `YYYY-MM` or `YYYY-MM-DD` folders.
You can preview the resulting tree before applying it.

## Upload to Lanzou Cloud

- Choose **Lanzou Cloud** or **Lanzou Pro** in the platform list; the choice is remembered.
- Click **Login** and enter your account and password. The app calls the official API over HTTPS directly — no embedded browser required.
- Passwords are never stored and the input box is cleared after sign-in; logs and UI show only masked values.
- If the API changes or risk control blocks you, use **Paste Cookie** as a fallback.
  - Lanzou Cloud: `ylogin` and `phpdisk_info` are both required.
  - Lanzou Pro: only `appToken` is needed; `uuid` is generated locally. If you only have the key, tick the advanced option and paste it alone. The key equals account credentials — never share it.
- Uploads run 3 files in parallel by default (adjustable 1–5). Files the server already has are reported as **Instant upload**; a local success cache skips unchanged files, and **Force re-upload** ignores it.
- Lanzou Pro support follows a proven, tested client implementation (login endpoint, headers, AES timestamp, `appToken`, Qiniu chunking). The UI still labels it experimental; server-side rejection is reported honestly and never retried in a loop.

## Search

The top search box finds settings, options, and help entries. Press **Enter** to jump to the first match.

## License

- The app runs in trial mode until activated.
- Enter the activation code in **Settings → License**; the machine code is shown there.
- Activation is stored locally and re-checked periodically.

## Command line

```text
FileDedupTool.exe --src "D:\Photos" --dst "D:\Kept" --dryrun --json
```

Use `--help` for the full option list. GUI mode starts when no arguments are given.

## Logs and configuration

- Logs: `%LOCALAPPDATA%\FileDedupTool\logs`
- Settings: `%APPDATA%\FileDedupTool\settings.json`
- Operation logs used by undo: `%LOCALAPPDATA%\FileDedupTool\ops`

Nothing is uploaded to the network unless you explicitly enable an AI or cloud feature.
