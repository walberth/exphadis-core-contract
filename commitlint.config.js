/** @type {import('@commitlint/types').UserConfig} */
module.exports = {
  extends: ["@commitlint/config-conventional"],
  ignores: [(message) => /^\s*wip(\([^)]*\))?\s*:/i.test(message)],
  rules: {
    "type-enum": [
      2,
      "always",
      [
        "build",
        "chore",
        "ci",
        "docs",
        "feat",
        "fix",
        "perf",
        "refactor",
        "revert",
        "style",
        "test",
        "release",
        "hook",
        "wip",
        "BUILD",
        "CHORE",
        "CI",
        "DOCS",
        "FEAT",
        "FIX",
        "PERF",
        "REFACTOR",
        "REVERT",
        "STYLE",
        "TEST",
        "RELEASE",
        "HOOK",
        "WIP"
      ]
    ],
    "subject-case": [0],
    "type-case": [0],
    "scope-case": [0],
    "header-max-length": [2, "always", 10000]
  }
};
